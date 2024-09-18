using System;
using System.Collections.Generic;

namespace Laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод значений дерева
            Console.WriteLine("Введите корневое значение дерева:");
            int rootValue = int.Parse(Console.ReadLine());
            TreeNode root = new TreeNode(rootValue);

            Console.WriteLine("Введите количество дочерних узлов:");
            int n = int.Parse(Console.ReadLine());

            // Ввод дочерних узлов для корневого элемента
            Console.WriteLine("Введите значения дочерних узлов:");
            for (int i = 0; i < n; i++)
            {
                int childValue = int.Parse(Console.ReadLine());
                root.AddChild(new TreeNode(childValue));
            }

            // Условие для поиска (например, значение больше 10)
            Console.WriteLine("Введите минимальное значение для поиска узлов:");
            int threshold = int.Parse(Console.ReadLine());

            // Создание объекта solve и вызов метода для поиска узлов
            solve solver = new solve();
            List<TreeNode> resultNodes = solver.SearchWithInclusion(root, node => node.Value > threshold);

            // Вывод результата
            Console.WriteLine("Узлы, удовлетворяющие условию:");
            foreach (var node in resultNodes)
            {
                Console.WriteLine(node.Value);
            }
            Console.ReadLine();
        }
    }
}
