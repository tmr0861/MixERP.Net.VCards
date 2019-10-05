using System.Text.RegularExpressions;

namespace MixERP.Net.VCards.Extensions
{
    public static class StringExtensions
    {
        public static string Or(this string str, string or) => string.IsNullOrWhiteSpace(str) ? or : str;

        public static string Unfold(this string str) => Regex.Replace(str, @"\r\n\s", (match) => string.Empty);

        public static int CountLines(this string str) => Regex.Matches(str, "$", RegexOptions.Multiline).Count;

    }
}