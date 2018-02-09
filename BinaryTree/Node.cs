using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Node
    {
        public Node(int value)
        {
            this.Value = value;
        }
        public Node Left { get; private set; }
        public int Value { get; }
        public Node Right { get; private set; }
        public void AddNode(Node node)
        {
            if (node.Value < this.Value)
            {
                if (this.Left != null)
                {
                    this.Left.AddNode(node);
                }
                else
                {
                    this.Left = node;
                }
            }
            else if (node.Value > this.Value)
            {
                if (this.Right != null)
                {
                    this.Right.AddNode(node);
                }
                else
                {
                    this.Right = node;
                }
            }
        }
        public void Visit()
        {
            this.Left?.Visit();
            Console.WriteLine(this.Value);
            this.Right?.Visit();
        }

        public Node Search(int value)
        {
            if (this.Value == value)
            {
                return this;
            }
            return value < this.Value ? this.Left?.Search(value) : this.Right?.Search(value);
        }
    }
}
