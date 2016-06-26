using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;

namespace LexicographicStringRank
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string input = Console.ReadLine ();
			char[] sortedInput = input.ToCharArray ();
			Array.Sort (sortedInput); 		
			int val = GetLexicographicRank (input, sortedInput.OfType<char> ().ToList ());
			Console.WriteLine ("Hello World!");
		}

		private static int GetLexicographicRank (string input, List<char> sortedInput)
		{
			int i = 0;
			int earlierPermutations = 0;
			int stringStartingWithEachChar = 0;
			while (i < input.Length) {
				stringStartingWithEachChar = GetFactorial (sortedInput.Count) / (sortedInput.Count);
				int getPositionInSortedArray = sortedInput.FindIndex (item => item == input [i]);
				if (getPositionInSortedArray == 0) {
					getPositionInSortedArray = 1;
				}

				sortedInput.Remove (input [i]);
				earlierPermutations += stringStartingWithEachChar * getPositionInSortedArray;
				i++;
			}

			return earlierPermutations; 
		}

		private static int GetFactorial (int n)
		{
			if (n == 1 || n == 0)
				return 1;
			return n * GetFactorial (n - 1);
		}
	}
}
