using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace LCPString
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string prefix = GetStringsLCP (new string[] { "abcdef", "abcedfrdf", "abcdaer", "sdfadsf", "sdfadf" }, 0, 4);
			Console.WriteLine ("Hello World!");
		}

		private static string GetStringsLCP (string[] input, int i, int j)
		{
			if (j - i == 1) {
				return GetStringLCP (input [i], input [j]);
			} else if (i == j) {
				return input [i];
			} else {
				return GetStringLCP (GetStringsLCP (input, i, (i + j) / 2), GetStringsLCP (input, (i + j) / 2 + 1, j));
			}
		}

		private static string GetStringLCP (string a, string b)
		{
			List<char> lcp = new List<char> ();
			int i = 0;
			while (i < a.Length && i < b.Length) {
				if (a [i] == b [i]) {
					lcp.Add (a [i]);
				} else {
					return new string (lcp.ToArray ());
				}
				i++;
			}

			return new string (lcp.ToArray ());
		}
	}
}
