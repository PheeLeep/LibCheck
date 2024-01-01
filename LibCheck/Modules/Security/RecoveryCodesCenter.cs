using LibCheck.Forms;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;

namespace LibCheck.Modules.Security {
    internal static class RecoveryCodesCenter {

        private static bool _isLoaded = false;
        private static List<RecoveryChallenge> challenges = new List<RecoveryChallenge>();

        internal static bool IsByPassed { get; private set; } = false;
        internal static int Count { get => challenges.Count; }

        internal static void Load() {
            if (_isLoaded) return;
            string path = Path.Combine(EnvVars.CredentialsInfo.FullName, "recovery_challenge.json");
            FileInfo f = new FileInfo(path);
            if (f.Exists) {
                using (StreamReader stream = new StreamReader(path)) {
                    using (JsonTextReader reader = new JsonTextReader(stream)) {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Formatting = Formatting.Indented;
                        while (reader.Read()) {
                            if (reader.TokenType == JsonToken.StartObject) {
                                RecoveryChallenge? challenge = serializer.Deserialize<RecoveryChallenge>(reader);
                                if (challenge != null)
                                    challenges.Add(challenge);
                            }
                        }
                        Logger.Log(Logger.LogEnums.Verbose, "Account recovery codes are loaded.");
                    }
                }
            }
            _isLoaded = true;
        }

        internal static void Unload() {
            if (!_isLoaded)
                return;
            for (int i = 0; i < challenges.Count; i++)
                challenges[i].Dispose();
            challenges.Clear();

            _isLoaded = false;
        }

        internal static bool Challenge(string code, string password) {
            if (!_isLoaded || Credentials.LoggedIn) return false;
            foreach (RecoveryChallenge rc in challenges) {
                try {
                    byte[] salt = Convert.FromBase64String(rc.Salt);
                    byte[] key = Encoding.UTF8.GetBytes(code);
                    string firstDecryptPhase = CryptComp.StringCrypt(rc.Challenge, key, salt, false);
                    if (string.IsNullOrEmpty(firstDecryptPhase) || !firstDecryptPhase.Contains(':'))
                        continue;

                    string[] variables = firstDecryptPhase.Split(':', StringSplitOptions.RemoveEmptyEntries);
                    if (variables.Length != 2) continue;
                    string username = variables[0];
                    string finalDecryptPhase = CryptComp.StringCrypt(variables[1], key, salt, false);

                    IsByPassed = true;
                    challenges.Remove(rc);
                    Save();
                    Credentials.EmergencyChangePassword(username, password, finalDecryptPhase);
                    IsByPassed = false;
                    return true;
                } catch (CryptographicException) {
                    Logger.Log(Logger.LogEnums.Warn, $"An attempt to recover account was failed.");
                } catch (Exception ex) {
                    Logger.Log(Logger.LogEnums.Error, $"An error occurred while recovering data. ({ex.Message})");
                    return false;
                }
            }
            return false;
        }

        internal static string[] Generate() {
            if (!Credentials.LoggedIn || Credentials.Librarian == null)
                throw new InvalidOperationException("Unable to generate while logged out.");
            string? username = Credentials.Librarian.Username;
            if (string.IsNullOrEmpty(username)) throw new InvalidOperationException("Username is empty.");
            for (int i = 0; i < challenges.Count; i++)
                challenges[i].Dispose();
            challenges.Clear();

            List<string> result = new List<string>();
            for (int i = 0; i < 10; i++) {
                string key = CryptComp.ConvertToString(CryptComp.GenerateSecurePassword(6, false, false, true, false));
                byte[] asin = CryptComp.GenerateRNGBytes();
                string firstCryptStr = CryptComp.StringCrypt(Encoding.UTF8.GetString(Database.Database.KeyHandover()),
                                                             Encoding.UTF8.GetBytes(key), asin);
                string finalCryptStr = CryptComp.StringCrypt($"{username}:{firstCryptStr}",
                                                             Encoding.UTF8.GetBytes(key), asin);
                challenges.Add(new RecoveryChallenge() {
                    Challenge = finalCryptStr,
                    Salt = Convert.ToBase64String(asin)
                });

                result.Add(key);
                PleaseWait.SetPWDText($"Code generated. ({i + 1}/10)");
            }
            Save();

            return result.ToArray();
        }

        internal static void Clear() {
            if (!Credentials.LoggedIn) throw new InvalidOperationException("Unable to remove account recovery while logged out.");
            if (Count == 0) return;
            for (int i = 0; i < challenges.Count; i++)
                challenges[i].Dispose();
            challenges.Clear();
            Save();
        }

        private static void Save() {
            string path = Path.Combine(EnvVars.CredentialsInfo.FullName, "recovery_challenge.json");
            using (StreamWriter streamWriter = new StreamWriter(path))
            using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter)) {
                PleaseWait.SetPWDText("Saving...");
                JsonSerializer serializer = new JsonSerializer {
                    Formatting = Formatting.Indented
                };
                serializer.Serialize(jsonWriter, challenges);
            }
        }
    }
}
