using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.Aztec.Internal;

namespace LibCheck.Modules.Security {
    internal static class USBAccRec {

        private static bool _isLoaded = false;

        
        private static List<USBDrive> drives = new List<USBDrive>();

        internal static void Load() {
            if (_isLoaded)
                throw new InvalidOperationException("Invalid to load drives. Please refresh.");

            FileInfo f = new FileInfo(Path.Combine(EnvVars.CredentialsInfo.FullName, "usb_cred.json"));
            if (f.Exists) {
                using (StreamReader stream = new StreamReader(Path.Combine(EnvVars.CredentialsInfo.FullName, "usb_cred.json"))) {
                    using (JsonTextReader reader = new JsonTextReader(stream)) {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Formatting = Formatting.Indented;
                        while (reader.Read()) {
                            if (reader.TokenType == JsonToken.StartObject) {
                                USBDrive? drive = serializer.Deserialize<USBDrive>(reader);
                                if (drive != null) 
                                    drives.Add(drive);
                            }
                        }
                        Logger.Log(Logger.LogEnums.Verbose, "Account recovery drives loaded.");
                    }
                }
            }
            _isLoaded = true;
        }

        internal static void Unload() {
            if (!_isLoaded)
                return;
            for(int i = 0; i < drives.Count; i++)
                drives[i].Dispose();
            drives.Clear();
            _isLoaded = false;
        }

        internal static USBDrive[] GetDriveNames() {
            if (!_isLoaded) return Array.Empty<USBDrive>();

            List<USBDrive> safeDrives = new List<USBDrive>();
            for (int i =0; i < drives.Count; i++) {
                USBDrive newSafeDrive = new USBDrive() {
                    DriveName = drives[i].DriveName,
                    Guid = drives[i].Guid,
                    Salt = "",
                    Hash = ""
                };
                safeDrives.Add(newSafeDrive);
            }
            return safeDrives.ToArray();
        }

        internal static void Register(USBDrive drive) {
            if (!Credentials.LoggedIn)
                throw new InvalidOperationException("Access is denied.");
        }
    }
}
