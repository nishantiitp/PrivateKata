using System;

namespace removeSpaces
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			char[] input = " there is     some .".ToCharArray ();
			RemoveSpaces (input);
			Console.WriteLine (input);
		}

		private static void RemoveSpaces (char[] input)
		{
			int inPlaceIterator = 0;
			int iterator = 0;
			bool wasPreviousSpace = true;
			for (iterator = 0; iterator < input.Length; iterator++) {
				if (IsSpaceNotAllowed (input [iterator], wasPreviousSpace)) {
					//if (inPlaceIterator > 0) {
					//	inPlaceIterator--;
					//}
				} else {
					input [inPlaceIterator] = input [iterator];
					if (input [iterator] == ' ') {
						wasPreviousSpace = true;
					} else {
						wasPreviousSpace = false;
					}

					inPlaceIterator++;
				}
			}
		}

		private static bool IsSpaceNotAllowed (char c, bool wasPreviousSpace)
		{
			return (c == ' ' && wasPreviousSpace) || ((c == ',' || c == '.') && wasPreviousSpace);
		}
	}
}
