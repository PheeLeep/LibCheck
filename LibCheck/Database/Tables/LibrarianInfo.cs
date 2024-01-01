using SQLite;

namespace LibCheck.Database.Tables {
    internal class LibrarianInfo {
        [PrimaryKey, NotNull]
        public string? Username { get; set; }

        [NotNull]
        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        [NotNull]
        public string? LastName { get; set; }

        [NotNull]
        public bool IsFemale { get; set; }
        [NotNull]
        public DateTime BirthDate { get; set; }

        [Ignore]
        public DateTime SafeBirthDate {
            get => BirthDate.Date;
            set => BirthDate = value;    
        }

        // <----------------->
        [NotNull]
        public string? SchoolName { get; set; }

        [NotNull]
        public string? SchoolGUID { get; set; }

        [NotNull]
        public double FeePerOverdueDay { get; set; }
    }
}
