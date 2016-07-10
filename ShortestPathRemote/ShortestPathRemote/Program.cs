using System;

namespace ShortestPathRemote
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			char[] input = "AO".ToCharArray ();
			PrintPathForString (input);
		}

		private static void PrintPathForString (char[] input)
		{
			int lastX = 0;
			int lastY = 0;
			int currentX = 0;
			int currentY = 0;

			foreach (char c in input) {
				currentY = (c - 'A') / 5;
				currentX = (c - 'A') % 5;

				int moveHorizontal = currentX - lastX;
				int moveVertical = currentY - lastY;
				lastX = currentX;
				lastY = currentY;

				if (moveHorizontal > 0) {
					while (moveHorizontal > 0) {
						Console.WriteLine ("Move Right");
						moveHorizontal--;
					}
				}

				if (moveHorizontal < 0) {
					while (moveHorizontal < 0) {
						Console.WriteLine ("Move Left");
						moveHorizontal++;
					}
				}

				if (moveVertical > 0) {
					while (moveVertical > 0) {
						Console.WriteLine ("Move Down");
						moveVertical--;
					}
				}
				if (moveVertical < 0) {
					while (moveVertical < 0) {
						Console.WriteLine ("Move Up");
						moveVertical++;
					}
				}

				Console.WriteLine ("Press OK");
			}
		}
	}
}
