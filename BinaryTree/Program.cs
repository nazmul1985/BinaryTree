using System;

namespace BinaryTree
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Create tree...");
            var tree = new Tree();
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                tree.AddNode(random.Next(0, 100));
            }

            tree.Traverse();

            Console.WriteLine("Enter value for search: ");

            var value = Console.ReadLine();
            var result = tree.Search(Convert.ToInt32(value));

            Console.WriteLine(result != null ? "Found the data." : "No found.");

            Console.ReadLine();
        }
    }
}