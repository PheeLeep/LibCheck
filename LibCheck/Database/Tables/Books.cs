using SQLite;

namespace LibCheck.Database.Tables {
    internal class Books {
        [PrimaryKey, NotNull]
        public string? ISBN { get; set; }

        [NotNull]
        public string? Title { get; set; }

        [NotNull]
        public string? Author { get; set; }

        [NotNull]
        public string? Genre { get; set; }

        [NotNull]
        public string? Publisher { get; set; }

        [NotNull]
        public string? Description { get; set; }

        [NotNull]
        public DateTime DatePublished { get; set; }

        [Ignore]
        public DateTime SafeDatePublished {
            get => DatePublished.Date;
            set => DatePublished = value;
        }

        [NotNull]
        public string? StudentID { get; set; }

        [NotNull]
        public bool IsLostOrDamaged { get; set; }

        public DateTime? DateToReturn { get; set; }

        [Ignore]
        public DateTime? SafeDateToReturn {
            get => DateToReturn?.Date;
            set => DateToReturn = value;
        }

        [NotNull]
        public bool ThreeDayNoticeSent { get; set; } = false;

        public string? ImagePath { get; set; }  
    }
}
