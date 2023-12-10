using System.Text.RegularExpressions;

namespace LibCheck.Modules {

    /// <summary>
    /// A class that houses Regex checkers for various formats.
    /// </summary>
    internal static partial class Regexes {

        [GeneratedRegex("^(?=[a-zA-Z])[-\\w.]{0,23}([a-zA-Z\\d]|(?<![-.])_)$")]
        private static partial Regex UsernameRegex();

        [GeneratedRegex(@"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$")]
        private static partial Regex PhoneRegex();

        [GeneratedRegex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")]
        private static partial Regex EmailRegex();

        [GeneratedRegex(@"^[a-zA-Z0-9]+$")]
        private static partial Regex AlphanumericRegex();

        [GeneratedRegex(@"^[a-zA-Z]+$")]
        private static partial Regex AlphabetRegex();

        [GeneratedRegex(@"[\w\x20]")]
        private static partial Regex AlphanumericSpaceRegex();


        internal static bool IsValidUsername(string username) => UsernameRegex().IsMatch(username); // Checks if the username is valid.
        internal static bool IsValidPhoneNumber(string phone) => PhoneRegex().IsMatch(phone);// Checks if the phone number is valid.
        internal static bool IsValidEmail(string email) => EmailRegex().IsMatch(email); // Checks if the email address is valid.
        internal static bool IsValidAlphanumeric(string alphanumeric) => AlphanumericRegex().IsMatch(alphanumeric); // Checks if the string is alphanumeric.
        internal static bool IsValidAlphabet(string alphabet) => AlphabetRegex().IsMatch(alphabet);
        internal static bool IsValidAlphanumSpace(string s) => AlphanumericSpaceRegex().IsMatch(s);
    }
}
