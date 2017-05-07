using System.Collections.Generic;
using System.Windows.Forms;

namespace AdamOneilSoftware
{
    public static class TreeViewExtensions
	{
		public static List<T> FindNodes<T>(this TreeView treeView) where T : TreeNode
		{
			List<T> results = new List<T>();
			foreach (TreeNode node in treeView.Nodes)
			{
				AddResult(node, results);
				FindNodesR<T>(node, results);
			}
			return results;
		}

		public static List<T> FindNodes<T>(this TreeNode treeNode) where T : TreeNode
		{
			List<T> results = new List<T>();
			FindNodesR<T>(treeNode, results);
			return results;
		}

		private static void FindNodesR<T>(TreeNode parent, List<T> results) where T : TreeNode
		{
			if (parent == null) return;
			foreach (TreeNode node in parent.Nodes)
			{
				AddResult(node, results);
				FindNodesR(node, results);
			}
		}

		private static void AddResult<T>(TreeNode node, List<T> results) where T : TreeNode
		{
			T checkNode = node as T;
			if (checkNode != null) results.Add(checkNode);
		}
	}
}
