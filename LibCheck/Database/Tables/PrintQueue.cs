using SQLite;

namespace LibCheck.Database.Tables {
    internal class PrintQueue {

        [PrimaryKey, NotNull]
        public string? QueueName { get; set; }

        [NotNull]
        public string? HashSHA256 { get; set; }

    }
}
