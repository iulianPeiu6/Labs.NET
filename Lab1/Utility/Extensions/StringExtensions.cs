using System;
using System.Linq;

namespace Utility.Extensions
{
    public static class StringExtensions
    {
        public static int GetNumberOfWords(this string text)
        {
            var separators = new char[] { ' ', '.', ',', '!', '?' };
            var words = text.Split(separators);
            words = words.ToList()
                .Where(word => word != string.Empty)
                .ToArray();
            return words.Length;
        }
    }
}
