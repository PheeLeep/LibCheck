using LibCheck.Database.Tables;
using System.Text;

namespace LibCheck.Modules {
    public static class Miscellaneous {
        public enum DatabaseMode {
            Read,
            Add,
            Update
        }

        internal static string[] Levels {
            get => new string[] { "Elementary", "Junior High", "Senior High", "Tertiary" };
        }

        internal static string[] Genres {
            get => new string[] { "Fiction",  "Non-fiction",  "Mystery", "Science Fiction", "Fantasy", "Romance",
                                  "Thriller", "Horror", "Biography", "History", "Self-help", "Poetry", "Others"};
        }
        internal static string GenerateFullName(LibrarianInfo? info, bool firstNameFirst = false, bool generateMI = true) {
            if (info == null) return "";

            StringBuilder fullName = new StringBuilder();
            StringBuilder miBuilder = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(info.MiddleName)) {
                if (!generateMI) {
                    miBuilder.Append(info.MiddleName);
                } else {
                    string[] mi = info.MiddleName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < mi.Length; i++) {
                        miBuilder.Append($"{mi[i].ToUpper()[0]}.");
                        if (i < mi.Length - 1)
                            miBuilder.Append(' ');
                    }
                }
            }

            fullName.Append($"{(firstNameFirst ?
                                $"{info.FirstName} {miBuilder} {info.LastName}" :
                                $"{info.LastName}, {info.FirstName} {miBuilder}")}");
            return fullName.ToString();
        }
        internal static string GenerateFullName(Students student, bool firstNameFirst = false, bool generateMI = true) {
            if (student == null) return "";

            StringBuilder fullName = new StringBuilder();
            StringBuilder miBuilder = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(student.MiddleName)) {
                if (!generateMI) {
                    miBuilder.Append(student.MiddleName);
                } else {
                    string[] mi = student.MiddleName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < mi.Length; i++) {
                        miBuilder.Append($"{mi[i].ToUpper()[0]}.");
                        if (i < mi.Length - 1)
                            miBuilder.Append(' ');
                    }
                }
            }

            fullName.Append($"{(firstNameFirst ?
                                $"{student.FirstName} {miBuilder} {student.LastName}" :
                                $"{student.LastName}, {student.FirstName} {miBuilder}")}");
            if (!string.IsNullOrWhiteSpace(student.Suffix) && !student.Suffix.Equals("(none)"))
                fullName.Append($" {student.Suffix}");
            return fullName.ToString();
        }

        internal static void ResetDGVColumns(DataGridView dgv, bool hideCols = true) {
            for (int i = 0; i < dgv.Columns.Count; i++) {
                dgv.Columns[i].AutoSizeMode = (i < dgv.Columns.Count - 1) ?
                                                DataGridViewAutoSizeColumnMode.AllCells :
                                                DataGridViewAutoSizeColumnMode.Fill;
                if (hideCols) dgv.Columns[i].Visible = false;
            }
        }

        internal static int CalculateDateExcptSun(DateTime from, DateTime to) {
            int daysDifference = (int)(to - from).TotalDays;

            // Exclude Sundays from the count
            for (int i = 0; i <= daysDifference; i++) {
                DateTime currentDay = from.AddDays(i);

                if (currentDay.DayOfWeek == DayOfWeek.Sunday)
                    daysDifference--;
            }
            return daysDifference;
        }
        internal static string Redact(string? stringToRedact) {
            if (string.IsNullOrWhiteSpace(stringToRedact) || stringToRedact.Length < 2)
                return "";

            if (Regexes.IsValidEmail(stringToRedact, out _)) {
                string[] splitEmail = stringToRedact.Split('@');
                string firstPart = splitEmail[0];
                int emailSize = firstPart[1..^1].Length;
                return $"{firstPart[0]}{new string('*', emailSize)}{firstPart[^1]}@{splitEmail[1]}";
            }

            int size = stringToRedact[1..^1].Length;

            return $"{stringToRedact[0]}{new string('*', size)}{stringToRedact[^1]}";
        }
    }
}
