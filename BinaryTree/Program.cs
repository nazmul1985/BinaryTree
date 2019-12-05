using System;
using System.Collections;

namespace BinaryTree
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Create tree...");
            var tree = new Tree();
            var random = new Random();
            var items = new ArrayList();
            for (var i = 0; i < 10; i++)
            {
                var next = random.Next(0, 100);
                items.Add(next);
                tree.AddNode(next);
            }

            var height = tree.GetHeight(tree.Root);

            Console.WriteLine($"Height of ({string.Join(',', items.ToArray())}): {height}");

            tree.Traverse();

            Console.WriteLine("Enter value for search: ");

            var value = Console.ReadLine();
            var result = tree.Search(Convert.ToInt32(value));

            Console.WriteLine(result != null ? "Found the data." : "No found.");

            Console.ReadLine();
        }
    }
}