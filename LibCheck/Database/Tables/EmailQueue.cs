using SQLite;

namespace LibCheck.Database.Tables {
    internal class EmailQueue {
        [PrimaryKey, NotNull]
        public required DateTime DateOccurred { get; set; }

        [NotNull]
        public required string ReceiverEmail { get; set; }

        [NotNull]
        public required string Text { get; set; }
    }
}
