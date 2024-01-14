using LibCheck.Modules;
using LibCheck.Modules.Security;
using SQLite;

namespace LibCheck.Database.Tables {
    internal class Notifs {

        [PrimaryKey, NotNull]
        public DateTime Date { get; set; }

        [NotNull]
        public string? Caption { get; set; }

        [NotNull]
        public string? Message { get; set; }

        internal static void CreateNotification(string caption, string message) {
            if (!Credentials.LoggedIn) return;
            Notifs n = new Notifs() {
                Date = DateTime.Now,
                Caption = caption,
                Message = message
            };
            if (!Database.Insert(n))
                Logger.Log(Logger.LogEnums.Warn, "Failed to create a notification.");
        }

        internal static int Count(bool getLatest = false) {
            if (!Credentials.LoggedIn) return 0;
            Notifs[] nfs = GetNotifications();
            return getLatest ? nfs.Count(nf => nf.Date >= Credentials.Librarian?.LastLoggedIn.Date) : nfs.Length;
        }

        internal static Notifs[] GetNotifications() {
            if (!Credentials.LoggedIn) return Array.Empty<Notifs>();
            if (Database.Read(out List<Notifs>? notifs) <= 0 || notifs == null)
                return Array.Empty<Notifs>();
            return notifs.ToArray();
        }

        internal static void Clear() {
            if (!Credentials.LoggedIn) return;
            if (!Database.DeleteAll<Notifs>())
                Logger.Log(Logger.LogEnums.Warn, "Failed to delete all notifications.");
        }

        internal static void DeleteLog(object obj) {
            if (!Credentials.LoggedIn) return;
            if (!Database.Delete(obj))
                Logger.Log(Logger.LogEnums.Warn, "Failed to delete notification.");
        }
    }
}
