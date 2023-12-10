using SQLite;

namespace LibCheck.Database.Tables {
    internal class Records {

        internal enum RecordStatus {
            BookAdded,
            BookModified,
            BookDeleted,
            BookBorrowed,
            BookReturned,
            BookMissingDamaged
        }

        [PrimaryKey, NotNull]
        public required DateTime DateOccurred { get; set; }

        [NotNull]
        public required string ISBN { get; set; }

        [NotNull]
        public required RecordStatus Category { get; set; }

        public string? AdditionalContext { get; set; }
    }
}
