using System.Runtime.InteropServices;

namespace LibCheck.Modules {

    /// <summary>
    /// A class that contains Windows native methods.
    /// </summary>
    internal static class WinNatives {

        [StructLayout(LayoutKind.Sequential)] //Same layout in mem
        public struct DEV_BROADCAST_VOLUME {
            public int dbcv_size;
            public int dbcv_devicetype;
            public int dbcv_reserved;
            public int dbcv_unitmask;
        }

        internal const int WM_DEVICECHANGE = 0x0219; //see msdn site
        internal const int DBT_DEVICEARRIVAL = 0x8000;
        internal const int DBT_DEVICEREMOVALCOMPLETE = 0x8004;
        internal const int DBT_DEVTYPVOLUME = 0x00000002;
        internal const int DBT_DEVTYP_DEVICEINTERFACE = 5;
        internal const int DBT_DEVTYP_HANDLE = 6;
        internal const int BROADCAST_QUERY_DENY = 0x424D5144;
        internal const int DBT_DEVICEQUERYREMOVE = 0x8001;   // Preparing to remove (any program can disable the removal)
        internal const int DBT_DEVICEREMOVECOMPLETE = 0x8004; // removed 
        internal const int DBT_DEVTYP_VOLUME = 0x00000002; // drive type is logical volume

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr CreateDesktop(string lpszDesktop, IntPtr lpszDevice, IntPtr pDevmode, int dwFlags, uint dwDesiredAccess, IntPtr lpsa);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool SwitchDesktop(IntPtr hDesktop);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool CloseDesktop(IntPtr hDesktop);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool SetThreadDesktop(IntPtr hDesktop);
        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr GetThreadDesktop(uint dwThreadId);
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern uint GetCurrentThreadId();
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);

        internal const uint GENERIC_ALL = 0x10000000;
    }
}
