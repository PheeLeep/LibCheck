using SQLite;

namespace LibCheck.Database.Tables {
    internal class Books {
        [PrimaryKey, NotNull]
        public required string ISBN { get; set; }

        [NotNull]
        public required string Title { get; set; }

        [NotNull]
        public required string Author { get; set; }

        [NotNull]
        public required string Description { get; set; }

        [NotNull]
        public required DateTime DatePublished { get; set; }

        [NotNull]
        public required string StudentID { get; set; }

        [NotNull]
        public required bool IsLostOrDamaged { get; set; }
    }
}
