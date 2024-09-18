using System.Collections.Generic;

namespace Laba2
{
    public class TreeNode
    {
        public int Value;
        public List<TreeNode> Children;

        public TreeNode(int value)
        {
            Value = value;
            Children = new List<TreeNode>();
        }

        public void AddChild(TreeNode child)
        {
            Children.Add(child);
        }
    }
}
