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
    }
}
