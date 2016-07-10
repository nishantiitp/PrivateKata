using System;
using System.Collections.Generic;

/// <summary>
/// Learnings:
/// 1. To access elements in a dictionary, we can directly use the key as the index.
///
/// </summary>

namespace SumZeroSubSequence
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			int[] input = { 6, 3, -1, -3, 4, -2, 2, 4, 6, -12, -7 };
			Dictionary<int, List<int>> indexValues = FindZeroSubSequence (input);
			PrintZeroSubsequences (indexValues, input);
		}

		private static void PrintZeroSubsequences (Dictionary<int, List<int>> indexValues, int[] input)
		{
			foreach (KeyValuePair<int, List<int>> kvp in indexValues) {
				if (kvp.Key == 0) {
					foreach (int index in kvp.Value) {
						PrintInput (input, 0, index);
					}
				} else {
					if (kvp.Value.Count > 1) {
						int i = 0;
						for (i = 0; i < kvp.Value.Count - 1; i++) {
							PrintInput (input, kvp.Value [i] + 1, kvp.Value [i + 1]);
						}
					}
				}
			}
		}

		private static void PrintInput (int[] input, int i, int j)
		{
			for (int k = i; k <= j; k++) {
				Console.Write ("  {0}", input [k]);
			}

			Console.WriteLine ();
		}

		private static Dictionary<int, List<int>> FindZeroSubSequence (int[] input)
		{
			int currentSum = 0;
			int i = 0;
			Dictionary<int, List<int>> sumIndex = new Dictionary<int, List<int>> ();
			while (i < input.Length) {
				currentSum += input [i];
				if (sumIndex.ContainsKey (currentSum)) {
					sumIndex [currentSum].Add (i);
				} else {
					sumIndex.Add (currentSum, new List<int> () { i });
				}

				i++;
			}

			return sumIndex;
		}
	}
}
