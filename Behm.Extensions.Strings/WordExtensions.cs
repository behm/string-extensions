using System;

namespace Behm.Extensions.Strings
{
    public static class WordExtensions
    {
        public static int WordCount(this string str)
        {
            if (str == null)
            {
                return 0;
            }

            return str.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
