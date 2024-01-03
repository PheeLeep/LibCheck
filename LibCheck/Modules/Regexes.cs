using LibCheck.Forms;
using System.Text.RegularExpressions;

namespace LibCheck.Modules {

    /// <summary>
    /// A class that houses Regex checkers for various formats.
    /// </summary>
    internal static partial class Regexes {

        [GeneratedRegex(@"^(?=(?:\D*\d){10}(?:(?:\D*\d){3})?$)[\d-]+$")]
        private static partial Regex ISBN10x13Pattern();

        [GeneratedRegex(@"^[a-zA-Z0-9_]{3,20}$")]
        private static partial Regex UsernameRegex();


        [GeneratedRegex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")]
        private static partial Regex EmailRegex();

        [GeneratedRegex(@"^[a-zA-Z0-9]+$")]
        private static partial Regex AlphanumericRegex();

        [GeneratedRegex(@"^[a-zA-Z]+$")]
        private static partial Regex AlphabetRegex();

        [GeneratedRegex(@"[\w\x20]")]
        private static partial Regex AlphanumericSpaceRegex();

        [GeneratedRegex("^\\d{11}$")]
        private static partial Regex StudentIDRegex();

        internal static bool IsValidISBN(string isbn) => ISBN10x13Pattern().IsMatch(isbn);
        internal static bool IsValidUsername(string username) => UsernameRegex().IsMatch(username); // Checks if the username is valid.
        internal static bool IsValidEmail(string email, out Match? m) {
            m = null;
            if (!EmailRegex().IsMatch(email)) return false;
            m = EmailRegex().Match(email);
            return true;
        }
        internal static bool IsValidAlphanumeric(string alphanumeric) => AlphanumericRegex().IsMatch(alphanumeric); // Checks if the string is alphanumeric.
        internal static bool IsValidAlphabet(string alphabet) => AlphabetRegex().IsMatch(alphabet);
        internal static bool IsValidAlphanumSpace(string s) => AlphanumericSpaceRegex().IsMatch(s);
        internal static bool IsValidStudentID(string id) => StudentIDRegex().IsMatch(id);

    }
}
