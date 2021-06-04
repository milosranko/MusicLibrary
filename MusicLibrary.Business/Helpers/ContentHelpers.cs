using System.Text;
using System.Text.RegularExpressions;

namespace MusicLibrary.Business.Helpers
{
    public static class ContentHelpers
    {
        private static readonly Regex CleanSpacesRegex = new Regex("[\\s\\r\\n]+", RegexOptions.Compiled);
        private static readonly Regex RemoveSpecialCharactersRegex = new Regex("[^a-zA-Z0-9]", RegexOptions.Compiled);

        public static string CleanContent(StringBuilder body)
        {
            return CleanSpacesRegex
                .Replace(RemoveSpecialCharactersRegex.Replace(body.ToString(), " ").ToString(), " ")
                .Trim()
                .ToLower();
        }

        public static string RemoveSpecialCharacters(this string value)
        {
            if (string.IsNullOrEmpty(value)) return value;

            return RemoveSpecialCharactersRegex.Replace(value, " ");
        }
    }
}
