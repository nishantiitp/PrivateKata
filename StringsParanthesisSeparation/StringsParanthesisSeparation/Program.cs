using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsParanthesisSeparation
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAllCombinations("", "abcd");
        }

        private static void PrintAllCombinations(string finalString, string v)
        {
            if(string.IsNullOrWhiteSpace(v))
            {
                Console.WriteLine(finalString);
                return;
            }
            int i = 0;
            for(i = 0; i<= v.Length - 1; i++)
            {
                PrintAllCombinations(finalString + "(" + v.Substring(0, i + 1) + ")", v.Substring(i + 1));
            }
        }
    }
}
