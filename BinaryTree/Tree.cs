using System;

namespace BinaryTree
{
    public class Tree
    {
        public Node Root { get; set; }

        public void AddNode(int value)
        {
            var node = new Node(value);
            if (Root == null)
            {
                Root = node;
            }
            else
            {
                Root.AddNode(node);
            }
        }

        public int GetHeight(Node root)
        {
            return root == null ? -1 : 1 + Math.Max(GetHeight(root.Left), GetHeight(root.Right));
        }

        public Node Search(int value)
        {
            return Root?.Search(value);
        }

        public void Traverse()
        {
            Root?.Visit();
        }
    }
}
