using System;
using System.IO;
using System.Security.Principal;

namespace TreeDiameter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string numNodesAndRootVal = Console.ReadLine ();
			string[] input = numNodesAndRootVal.Split (new char[] { ' ' });
			int numNodes = Int32.Parse (input [0]);
			int rootVal = Int32.Parse (input [1]);
			BinaryTree tree = new BinaryTree (rootVal);
			while (numNodes > 1) {
				string position = Console.ReadLine ();
				string value = Console.ReadLine ();
				tree.AddNodeToRoot (tree.Root, Int32.Parse (value), position);
				numNodes--;
			}

			Console.WriteLine ("{0}", DiameterOfTree (tree.Root));
		}

		private static int DiameterOfTree (BinaryTreeNode root)
		{
			if (root == null) {
				return 0;
			}
			int heightOfLeftTree = heightOfTree (root.Left);
			int heightOfRightTree = heightOfTree (root.Right);
			return Max ((1 + heightOfLeftTree + heightOfRightTree), Max (DiameterOfTree (root.Left), DiameterOfTree (root.Right)));
		}

		private static int heightOfTree (BinaryTreeNode root)
		{
			if (root == null)
				return 0;
			else
				return 1 + Max (heightOfTree (root.Left), heightOfTree (root.Right));
		}

		private static int Max (int a, int b)
		{
			return a > b ? a : b;
		}
	}

	public class BinaryTreeNode
	{
		public BinaryTreeNode Left;
		public BinaryTreeNode Right;
		public int Value;

		public BinaryTreeNode (int val)
		{
			Left = null;
			Right = null;
			Value = val;
		}
	}

	public class BinaryTree
	{
		public BinaryTreeNode Root;

		public BinaryTree (int val)
		{
			Root = new BinaryTreeNode (val);
		}

		public void AddNodeToRoot (BinaryTreeNode root, int val, string position)
		{
			if (position.Length == 1) {
				if (position.Equals ("L")) {
					root.Left = new BinaryTreeNode (val);
				} else {
					root.Right = new BinaryTreeNode (val);
				}
			} else {
				if (position [0].Equals ('L')) {
					AddNodeToRoot (root.Left, val, position.Substring (1));
				} else {
					AddNodeToRoot (root.Right, val, position.Substring (1));
				}
			}
		}
	}
}
