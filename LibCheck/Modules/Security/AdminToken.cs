namespace LibCheck.Modules.Security {
    internal class AdminToken {
        internal string Username { get; set; }
        internal string Salt { get; set; }
        internal string Hash { get; set; }
        internal string SQLCipherDBKey { get; set; }
    }
}
