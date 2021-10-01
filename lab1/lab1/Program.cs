using System;
using Utility.Extensions;
namespace lab1
{
    class Program
    {
        static void Main()
        {
            string ceva = "ana are mere";
            int numberOfWords=ceva.GetNumberOfWords();
            Console.WriteLine(numberOfWords);
            
            
        }
    }
}
