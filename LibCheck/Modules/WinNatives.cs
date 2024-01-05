using System.Runtime.InteropServices;

namespace LibCheck.Modules {

    /// <summary>
    /// A class that contains Windows native methods.
    /// </summary>
    internal static class WinNatives {

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern IntPtr CreateDesktop(string lpszDesktop,
                                                    IntPtr lpszDevice,
                                                    IntPtr pDevmode,
                                                    int dwFlags,
                                                    uint dwDesiredAccess,
                                                    IntPtr lpsa);

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
