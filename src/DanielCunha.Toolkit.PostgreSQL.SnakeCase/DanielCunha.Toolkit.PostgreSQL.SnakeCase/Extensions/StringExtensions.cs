using System.Text.RegularExpressions;

namespace DanielCunha.Toolkit.PostgreSQL.SnakeCase.Extensions
{
    public static class StringExtensions
    {
        public static string ToSnakeCase(this string value)
        {
            if (string.IsNullOrEmpty(value)) 
                return value;

            var startUnderscores = Regex.Match(value, @"^_+");
            return startUnderscores + Regex.Replace(value, @"([a-z0-9])([A-Z])", "$1_$2").ToLower();
        }
    }

}