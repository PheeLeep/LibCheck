﻿using SQLite;

namespace LibCheck.Database.Tables {
    internal class EmailQueue {
        [PrimaryKey, NotNull]
        public DateTime DateOccurred { get; set; }

        [NotNull]
        public string? StudentID { get; set; }

        [NotNull]
        public string? MailTo { get; set; }

        [NotNull]
        public string? Subject { get; set; }

        [NotNull]
        public string? Body { get; set; }
    }
}
