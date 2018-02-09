using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Tree
    {
        public Node Root { get; set; }

        public void AddNode(int value)
        {
            var node = new Node(value);
            if (this.Root == null)
            {
                this.Root = node;
            }
            else
            {
                this.Root.AddNode(node);
            }
        }

        public Node Search(int value)
        {
            return this.Root?.Search(value);
        }

        public void Traverse()
        {
            this.Root?.Visit();
        }
    }
}
