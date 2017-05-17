using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AdamOneilSoftware
{
    public static class TreeViewExtensions
    {
        public static List<T> FindNodes<T>(this TreeView treeView, bool recursive = true, Func<T, bool> filter = null) where T : TreeNode
        {
            List<T> results = new List<T>();
            foreach (TreeNode node in treeView.Nodes)
            {
                AddResult(node, results);
                if (recursive) FindNodesR<T>(node, results, true, filter);
            }
            return results;
        }

        public static List<T> FindNodes<T>(this TreeNode treeNode, bool recursive = true, Func<T, bool> filter = null) where T : TreeNode
        {
            List<T> results = new List<T>();
            FindNodesR<T>(treeNode, results, recursive, filter);
            return results;
        }

        private static void FindNodesR<T>(TreeNode parent, List<T> results, bool recursive = true, Func<T, bool> filter = null) where T : TreeNode
        {
            if (parent == null) return;
            foreach (TreeNode node in parent.Nodes)
            {
                AddResult(node, results);
                if (recursive) FindNodesR(node, results, true, filter);
            }
        }

        private static void AddResult<T>(TreeNode node, List<T> results, Func<T, bool> filter = null) where T : TreeNode
        {
            T checkNode = node as T;
            if (checkNode != null && (filter?.Invoke(checkNode) ?? true)) results.Add(checkNode);
        }

        public static void Execute(this TreeView treeView, Action<TreeNode> action, Func<TreeNode, bool> filter = null)
        {
            foreach (TreeNode node in treeView.Nodes) ExecuteR(node, action, filter);
        }

        public static void Execute(this TreeNode treeNode, Action<TreeNode> action, Func<TreeNode, bool> filter = null)
        {
            foreach (TreeNode node in treeNode.Nodes) ExecuteR(node, action, filter);
        }

        private static void ExecuteR(TreeNode node, Action<TreeNode> action, Func<TreeNode, bool> filter = null)
        {
            if (filter?.Invoke(node) ?? true)
            {
                action.Invoke(node);
                foreach (TreeNode childNode in node.Nodes) ExecuteR(childNode, action, filter);
            }
        }

        public static void CheckChildNodes(this TreeNode treeNode, bool isChecked, Func<TreeNode, bool> filter = null)
        {
            Execute(treeNode, (nd) => nd.Checked = isChecked, filter);
        }

        public static T FindParentNode<T>(this TreeNode node) where T : TreeNode
        {
            TreeNode test = node;
            while (true)
            {
                TreeNode parent = test.Parent;
                if (parent == null) break;
                T result = parent as T;
                if (result != null) return result;
                test = parent;
            }
            return null;
        }
    }
}