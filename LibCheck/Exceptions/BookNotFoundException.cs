namespace LibCheck.Exceptions {
    public class BookNotFoundException : InvalidOperationException {

        public BookNotFoundException(string message, string? expectedISBN = "")
               : base($"{message} (Expected ISBN: {expectedISBN})") {
        }

        public BookNotFoundException(string expectedISBN = "") : base(Concatenate(expectedISBN)) {
        }

        private static string Concatenate(string isbn) {
            if (string.IsNullOrEmpty(isbn))
                return "Unable to find a book.";
            return $"A book with the ISBN of '{isbn}' does not exist in the database.";
        }
    }
}
