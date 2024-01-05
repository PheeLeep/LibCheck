using SQLite;

namespace LibCheck.Database.Tables {
    internal class RecentEmail {
        [PrimaryKey, NotNull]
        public DateTime DateOccurred { get; set; }

        [Ignore]
        public DateTime SafeDateOccurred {
            get => DateOccurred.Date;
            set => DateOccurred = value;
        }

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
