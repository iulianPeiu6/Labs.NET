using System;

namespace Utility.Extensions
{
    public static class StringExtensions
    {
        public static int GetNumberOfWords(this string text)
        {
            //throw new NotImplementedException();
            string[] words = text.Split(' ');
            int count = 0;
            foreach (var word in words)
            {
                count++;
            }

            return count;

        }
    }
}
