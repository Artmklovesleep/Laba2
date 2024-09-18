using System;
using System.Collections.Generic;

namespace Laba2
{
    public class solve
    {
        // Метод поиска с включением
        public List<TreeNode> SearchWithInclusion(TreeNode root, Func<TreeNode, bool> condition)
        {
            List<TreeNode> result = new List<TreeNode>();
            DFS(root, condition, result);
            return result;
        }

        // Поиск в глубину (DFS)
        public void DFS(TreeNode node, Func<TreeNode, bool> condition, List<TreeNode> result)
        {
            if (node == null) return;

            // Если узел удовлетворяет условию, добавляем его в результат
            if (condition(node))
            {
                result.Add(node);
            }

            // Рекурсивно обходим всех потомков
            foreach (var child in node.Children)
            {
                DFS(child, condition, result);
            }
        }
    }
}
