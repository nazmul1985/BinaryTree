using System;
using System.Runtime.InteropServices.ComTypes;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create tree...");
            //var nodes = new[] { 5, 1, 4, 7, 8, 9, 12, 10, 6, 3, 14, 2 };
            var tree = new Tree();
            //foreach (var node in nodes)
            //{
            //    tree.AddNode(node);
            //}
            var random = new Random();
            for (int i = 0; i < 10; i++)
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
