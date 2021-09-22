using System;

namespace Behm.Extensions.Strings
{
    public static class StringExtensions
    {
        public static string GetNullIfEmptyString(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return null;
            }

            return str;
        }

        public static string GetEmptyStringIfNull(this string str)
        {
            if (str == null)
            {
                return "";
            }

            return str;
        }

        public static string GetDefaultIfEmpty(this string str, string defaultValue)
        {
            if (string.IsNullOrEmpty(str))
            {
                return defaultValue;
            }

            return str;
        }

        public static bool IsEmpty(this string str)
        {
            return str == "" || str == string.Empty;
        }

        public static bool IsInteger(this string str)
        {
            return int.TryParse(str, out var _);
        }

        public static bool IsNumeric(this string str)
        {
            return double.TryParse(str, out var _);
        }

        public static string Reverse(this string str)
        {
            if (string.IsNullOrWhiteSpace(str) || str.Length == 1)
            {
                return str;
            }

            var reversed = new char[str.Length];
            var index = 0;

            for (var i=reversed.Length; i>0; i--)
            {
                reversed[index++] = str[i-1];
            }

            return new String(reversed);
        }

        public static string Left(this string str, int count)
        {
            if (str == null)
            {
                return str;
            }

            if (str.Length <= count)
            {
                return str;
            }

            return str.Substring(0, count);
        }

        public static string Right(this string str, int count)
        {
            if (str == null)
            {
                return str;
            }

            if (str.Length <= count)
            {
                return str;
            }

            return str.Substring(str.Length - count);
        }
    }
}
