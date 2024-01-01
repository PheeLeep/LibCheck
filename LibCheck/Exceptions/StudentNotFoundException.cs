namespace LibCheck.Exceptions {
    internal class StudentNotFoundException : InvalidOperationException {
        public StudentNotFoundException(string expectedID) : base(Concatenate(expectedID)) {
        }

        private static string Concatenate(string id) {
            if (string.IsNullOrEmpty(id))
                return "Unable to find a student in the database.";
            return $"A student with the ID of '{id}' does not exist in the database.";
        }
    }
}
