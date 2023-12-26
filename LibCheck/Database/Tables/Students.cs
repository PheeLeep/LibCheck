using SQLite;

namespace LibCheck.Database.Tables {
    internal class Students {

        [PrimaryKey, NotNull]
        public string? StudentID { get; set; }

        [NotNull]
        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        [NotNull]
        public string? LastName { get; set; }

        [NotNull]
        public string? Suffix { get; set; }

        [NotNull]
        public bool IsFemale { get; set; }

        [NotNull]
        public DateTime BirthDate { get; set; }

        [NotNull]
        public int Level { get; set; }

        [NotNull]
        public string? GradeSection { get; set; }

        [NotNull]
        public string? EmailAddress { get; set; }
    }
}
