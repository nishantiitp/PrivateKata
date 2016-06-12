using System;

/// <summary>
/// Generates permutations of a string. The idea here is to keep a part of the string fixed, and swap the character with others in each iteration.
/// </summary>

namespace PermutationsNumber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			string input = Console.ReadLine ();
			PrintPermutations (input, 0, input.Length - 1);
		}

		private static void PrintPermutations (string input, int start, int end)
		{
			if (start == end) {
				Console.WriteLine (input);
				return;
			}

			for (int i = start; i <= end; i++) {
				input = SwapCharacterinString (input, start, i);
				PrintPermutations (input, start + 1, end);
				input = SwapCharacterinString (input, start, i);
			}
		}

		private static string SwapCharacterinString (string input, int l, int r)
		{
			char c = input [l];
			string x = new string (new char[] { input [r] });
			input = input.Remove (l, 1);
			input = input.Insert (l, x);
			x = new string (new char[] { c });
			input = input.Remove (r, 1);
			input = input.Insert (r, x);
			return input;
		}
	}
}