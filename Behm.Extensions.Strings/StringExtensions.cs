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
    }
}
