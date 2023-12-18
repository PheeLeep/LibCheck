using System.Management;

namespace LibCheck.Modules {

    /// Code Cited: https://stackoverflow.com/a/1176089
    internal static class USBSerialNumber {

        static string _serialNumber;
        static string _driveLetter;

        public static string getSerialNumberFromDriveLetter(string driveLetter) {
            _driveLetter = driveLetter.ToUpper();

            if (!_driveLetter.Contains(":")) {
                _driveLetter += ":";
            }

            matchDriveLetterWithSerial();

            return _serialNumber;
        }

        private static void matchDriveLetterWithSerial() {

            string[] diskArray;
            string driveNumber;
            string driveLetter;

            ManagementObjectSearcher searcher1 = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDiskToPartition");
            foreach (ManagementObject dm in searcher1.Get()) {
                diskArray = null;
                driveLetter = getValueInQuotes(dm["Dependent"].ToString());
                diskArray = getValueInQuotes(dm["Antecedent"].ToString()).Split(',');
                driveNumber = diskArray[0].Remove(0, 6).Trim();
                if (driveLetter == _driveLetter) {
                    /* This is where we get the drive serial */
                    ManagementObjectSearcher disks = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
                    foreach (ManagementObject disk in disks.Get()) {

                        if (disk["Name"].ToString() == ("\\\\.\\PHYSICALDRIVE" + driveNumber) & disk["InterfaceType"].ToString() == "USB") {
                            _serialNumber = parseSerialFromDeviceID(disk["PNPDeviceID"].ToString());
                        }
                    }
                }
            }
        }

        private static string parseSerialFromDeviceID(string deviceId) {
            string[] splitDeviceId = deviceId.Split('\\');
            string[] serialArray;
            string serial;
            int arrayLen = splitDeviceId.Length - 1;

            serialArray = splitDeviceId[arrayLen].Split('&');
            serial = serialArray[0];

            return serial;
        }

        private static string getValueInQuotes(string inValue) {
            string parsedValue = "";

            int posFoundStart = 0;
            int posFoundEnd = 0;

            posFoundStart = inValue.IndexOf("\"");
            posFoundEnd = inValue.IndexOf("\"", posFoundStart + 1);

            parsedValue = inValue.Substring(posFoundStart + 1, (posFoundEnd - posFoundStart) - 1);

            return parsedValue;
        }
    }
}
