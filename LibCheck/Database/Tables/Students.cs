using SQLite;

namespace LibCheck.Database.Tables {
    internal class Students {

        internal enum StudentLevel {
            Elementary,
            JuniorHigh,
            SeniorHigh,
            Tertiary
        }

        [PrimaryKey, NotNull]
        public required string StudentID { get; set; }

        [NotNull]
        public required string FirstName { get; set; }

        public string? MiddleName { get; set; }

        [NotNull]
        public required string LastName { get; set; }

        [NotNull]
        public required string Suffix { get; set; }

        [NotNull]
        public bool IsFemale { get; set; }

        [NotNull]
        public DateTime BirthDate { get; set; }

        [NotNull]
        public required int Level { get; set; }

        [NotNull]
        public required string GradeSection { get; set; }

        [NotNull]
        public required string EmailAddress {  get; set; }
    }
}
