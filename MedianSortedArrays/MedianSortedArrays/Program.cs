using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace MedianSortedArrays
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] arr1 = new int[] { 1, 12, 15, 26, 38 };
			int[] arr2 = new int[] { 2, 13, 17, 30, 45 };

			int median = FindMedian (arr1, arr2);
			Console.WriteLine (median);
		}

		private static int FindMedian (int[] arr1, int[] arr2)
		{
			bool isAverageMedian = (arr1.Length + arr2.Length) % 2 == 0;
			int medianPosition = (arr1.Length + arr2.Length) / 2;
			int l = 0;
			int r = 0;
			int position = 0;
			int currentMedian = 0;
			while (position != medianPosition && l < arr1.Length && r < arr2.Length) {
				if (arr1 [l] < arr2 [r]) {
					currentMedian = arr1 [l];
					l++;
					position++;
				} else {
					currentMedian = arr2 [r];
					r++;
					position++;
				}
			}

			while (l < arr1.Length && position != medianPosition) {
				l++;
				position++;
			}

			while (r < arr2.Length && position != medianPosition) {
				r++;
				position++;
			}

			if (position == medianPosition && isAverageMedian) {
				if (arr1 [l] < arr2 [r]) {
					currentMedian = (currentMedian + arr1 [l]) / 2;
				} else {
					currentMedian = (currentMedian + arr2 [r]) / 2;
				}
			}

			return currentMedian;
		}
	}
}
