using SQLite;

namespace LibCheck.Database.Tables {
    internal class Records {

        internal enum RecordStatus {
            BookAdded,
            BookModified,
            BookDeleted,
            BookBorrowed,
            BookReturned,
            BookMissingDamaged,
            BookRestored,
            BookOverdue
        }

        [PrimaryKey, NotNull]
        public DateTime DateOccurred { get; set; }

        [NotNull]
        public string? ISBN { get; set; }

        [NotNull]
        public string? StudentID { get; set; }

        [NotNull]
        public RecordStatus Category { get; set; }

        public string? AdditionalContext { get; set; }
    }
}
