using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using LibCheck.Database.Tables;
using LibCheck.Forms;
using LibCheck.Modules.Security;
using MimeKit;
using System.Text;

namespace LibCheck.Modules {
    internal static class EmailService {

        internal delegate void EmailQueueChangedDelegate();

        internal static event EmailQueueChangedDelegate? EmailQueueChanged;

        internal static int EmailQueueCount {
            get => _emailCount;
            private set {
                _emailCount = value;
                if (_emailCount != value)
                    EmailQueueChanged?.Invoke();
            }
        }
        private static GmailService? service;
        private static readonly object _lock = new object();
        private static int _timeOut = 0;
        private static int _emailCount = 0;

        private static readonly Task _loopTask = new Task(() => {
            while (IsInitialized && !CrashControl.IsSCRAMed) {
                Task.Delay(1000).Wait();

                // Check for due.
                if (Database.Database.Read(out List<Books>? books, whereCond: $"StudentID <> '(none)'") > 0
                        && books != null) {

                    DateTime currentDate = DateTime.Now.Date;
                    foreach (Books b in books) {
                        if (b.DateToReturn != null) {
                            if (Database.Database.Read(out List<Students>? s, whereCond: $"StudentID = '{b.StudentID}'") <= 0
                                || s == null)
                                continue;

                            DateTime dueDate = b.DateToReturn.Value;
                            if (Miscellaneous.CalculateDateExcptSun(currentDate, dueDate) <= 3
                                && !b.IsLostOrDamaged && !b.ThreeDayNoticeSent) {
                                b.ThreeDayNoticeSent = true;

                                string body = Properties.Resources.OngoingDueEmail
                                                       .Replace("%school%", Credentials.Librarian?.SchoolName)
                                                       .Replace("%isbn%", b.ISBN)
                                                       .Replace("%title%", b.Title)
                                                       .Replace("%due%", b.DateToReturn?.ToString("dd/MM/yyyy"))
                                                       .Replace("%librarian%", Miscellaneous.GenerateFullName(Credentials.Librarian));

                                if (!Queue(s[0], body, "Due Soon") || !Database.Database.Update(b))
                                    Logger.Log(Logger.LogEnums.Error, "An error occurred while sending a due.");

                                Notifs.CreateNotification("Due Soon",
                                                          $"A student {Miscellaneous.GenerateFullName(s[0])} has an upcoming due " +
                                                          $" for the book '{b.Title}' " +
                                                          $"(Due Date: {b.DateToReturn?.ToString("dd/MM/yyyy")}).");
                            }
                        }
                    }
                }
                if (_timeOut == 0) {
                    _timeOut = 30;
                    if (Database.Database.Read(out List<EmailQueue>? queues) <= 0 || queues == null)
                        continue;
                    EmailQueue queue = queues[0];
                    Database.Database.Delete(queue);
                    string redact = Miscellaneous.Redact(queue.MailTo);
                    if (!Send(queue.StudentID, queue.MailTo, queue.Body, queue.Subject)) {
                        Logger.Log(Logger.LogEnums.Error, $"Couldn't send an email {redact}");
                        continue;
                    }
                    Logger.Log(Logger.LogEnums.Info, $"Queue email to {redact} is now sent.");
                    RecentEmail recent = new RecentEmail() {
                        Body = queue.Body,
                        Subject = queue.Subject,
                        DateOccurred = queue.DateOccurred,
                        StudentID = queue.StudentID,
                        MailTo = queue.MailTo
                    };
                    if (!Database.Database.Insert(recent))
                        Logger.Log(Logger.LogEnums.Error, "Failed to write a log of an email.");

                    EmailQueueCount = queues.Count - 1;
                    continue;
                }
                _timeOut--;
            }
        });

        internal static bool IsInitialized { get => service != null; }

        internal static void Initialize(CancellationToken ct) {
            try {
                if (IsInitialized) return;
                if (!Database.Database.IsConnected)
                    throw new InvalidOperationException("Database must be connected before the email service.");
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

                string[] scopes = { GmailService.Scope.GmailSend };
                FileInfo clientFile = new FileInfo(Path.Combine(EnvVars.CredentialsInfo.FullName, "gmailclient.json"));

                if (!clientFile.Exists)
                    throw new FileNotFoundException("Email credentials not found!", clientFile.FullName);

                using (var stream = new FileStream(clientFile.FullName, FileMode.Open, FileAccess.Read)) {
                    Logger.Log(Logger.LogEnums.Verbose, "Loading up the email credential.");

                    FileDataStore fds = new FileDataStore(EnvVars.CredentialsInfo.FullName, true);
                    Logger.Log(Logger.LogEnums.Verbose, "Authorizing...");
                    var creds = GoogleWebAuthorizationBroker.AuthorizeAsync(GoogleClientSecrets.FromStream(stream).Secrets,
                                                                         scopes,
                                                                         "user",
                                                                         ct,
                                                                         fds).Result;

                    Logger.Log(Logger.LogEnums.Verbose, "Initializing email service...");
                    service = new GmailService(new BaseClientService.Initializer {
                        HttpClientInitializer = creds,
                    });
                    _loopTask.Start();
                    Logger.Log(Logger.LogEnums.Info, "Email service initialized.");
                }
            }  catch (Exception ex) {
                if (ex is AggregateException) throw;
                CrashControl.SCRAM(ex);
            }
        }

        internal static void Unload() {
            if (!IsInitialized) return;
            service?.Dispose();
            service = null;
            Logger.Log(Logger.LogEnums.Info, "Email service stopped.");
        }


        internal static bool Queue(Students? student, string? body, string? subject = "LibCheck Generic Notification") {
            if (!IsInitialized) return false;
            if (student == null) return false;
            if (string.IsNullOrWhiteSpace(body)) return false;
            if (string.IsNullOrWhiteSpace(subject)) return false;

            lock (_lock) {

                if (Database.Database.Read(out List<EmailQueue>? queues, whereCond: $"StudentID = '{student.StudentID}'") > 0
                    && queues != null) {
                    List<EmailQueue> queues_changedEmail = queues.FindAll(q => q != null && !string.IsNullOrWhiteSpace(q.MailTo)
                                                                               && !q.MailTo.Equals(student.EmailAddress));
                    if (queues_changedEmail.Any()) {
                        foreach (EmailQueue q in queues_changedEmail) {
                            Database.Database.Delete(q);
                        }
                    }
                }

                EmailQueue queue = new EmailQueue() {
                    DateOccurred = DateTime.Now,
                    Subject = subject,
                    Body = body,
                    MailTo = student.EmailAddress,
                    StudentID = student.StudentID
                };

                Database.Database.Insert(queue);
                EmailQueueCount = Database.Database.Read<EmailQueue>(out _);
                return true;
            }
        }

        private static bool Send(string? studentID, string? mailTo, string? body, string? subject) {
            if (!IsInitialized) return false;
            if (string.IsNullOrWhiteSpace(mailTo) || !Regexes.IsValidEmail(mailTo, out _))
                return false;
            if (string.IsNullOrWhiteSpace(body)) return false;
            if (string.IsNullOrWhiteSpace(subject)) return false;
            if (string.IsNullOrWhiteSpace(Credentials.Librarian?.LibraryEmail)) return false;
            lock (_lock) {
                try {

                    var msg = new MimeMessage() {
                        Subject = subject,
                        Body = new TextPart("html") {
                            Text = body
                        },
                        Date = DateTime.Now
                    };
                    msg.From.Add(new MailboxAddress("LibCheck Email Notifier", Credentials.Librarian?.LibraryEmail));
                    msg.To.Add(new MailboxAddress("", mailTo));

                    var Base64txt = Convert.ToBase64String(Encoding.UTF8.GetBytes(msg.ToString()))
                                                            .Replace('+', '-')
                                                            .Replace('/', '_')
                                                            .Replace("=", "");

                    Logger.Log(Logger.LogEnums.Verbose, $"Attempting to send an email to {Miscellaneous.Redact(mailTo)}...");
                    if (service?.Users.Messages.Send(new Google.Apis.Gmail.v1.Data.Message {
                        Raw = Base64txt
                    }, Credentials.Librarian?.LibraryEmail).Execute() == null)
                        throw new InvalidOperationException("Sent failure! It might be due to internet connection or other factors.");
                    Logger.Log(Logger.LogEnums.Info, "Email sent.");
                    return true;
                } catch (Exception ex) {
                    Logger.Log(Logger.LogEnums.Error, "Failed to send due to an error and it's now" +
                                                      $" on queue for later resent attempt. ({ex.Message}).");

                    EmailQueue? queue = new EmailQueue() {
                        DateOccurred = DateTime.Now,
                        StudentID = studentID,
                        Subject = subject,
                        Body = body,
                        MailTo = mailTo
                    };
                    Database.Database.Insert(queue);
                    EmailQueueCount = Database.Database.Read<EmailQueue>(out _);
                    return false;
                }
            }
        }
    }
}
