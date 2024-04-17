using System.Text;
using System.Text.RegularExpressions;

namespace MusicLibrary.Business.Helpers;

internal static class ContentHelpers
{
    private static readonly Regex CleanSpacesRegex = new("[\\s\\r\\n]+", RegexOptions.Compiled);
    private static readonly Regex RemoveSpecialCharactersRegex = new("[^a-zA-Z0-9]", RegexOptions.Compiled);

    public static string GetContentText(string file, string[] tags)
    {
        var sb = new StringBuilder();

        sb.AppendLine(file.Remove(0, 3).Replace("\\", " ").Replace(".", " "));
        sb.AppendLine(string.Join(" ", tags));

        return CleanContent(sb);
    }

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
