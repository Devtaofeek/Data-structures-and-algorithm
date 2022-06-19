using System;

namespace Data_structures_and_algorithm.Tree
{
    /*
     
     */
    public class TeeTree
    {
        public class Node
        {
            public Node(int value)
            {
                Value = value;
            }
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }
        public Node Root { get; set; }


        public void Insert(int value)
        {
            Root = Insert(Root, value);
        }
        private Node Insert(Node node, int value)
        {
            if (node == null)
            {
                node = new Node(value);
                return node;
            }

            if (value > node.Value)
            {
                node.Right = Insert(node.Right, value);
            }
            else
            {
                node.Left = Insert(node.Left, value);
            }

            return node;
        }

        public bool Contains(int value)
        {
            if (Root == null)
            {
                return false;
            }

            var current = Root;

            while (current != null)
            {
                if (current.Value == value)
                {
                    return true;
                }
                else if (current.Value > value)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
            }

            return false;
        }

        public int Height(Node node)
        {
            if (node == null)
            {
                return -1;
            }
            if (node.Left == null && node.Right == null)
            {
                return 0;
            }

            var leftheight = Height(node.Left);
            var rightHeight = Height(node.Right);
            return 1 + Math.Max(leftheight, rightHeight);

        }

        public int MinimumInatree(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            if (node.Left == null && node.Right == null)
            {
                return node.Value;
            }
            var left = MinimumInatree(node.Left);
            var right = MinimumInatree(node.Left);
            return Math.Min(Math.Min(left, right), node.Value);
        }

        public void Invert()
        {
            Invert(Root);
        }

        private Node Invert(Node node)
        {
            if (node == null)
            {
                return node;
            }

            if (node.Left == null && node.Right == null)
            {
                return node;
            }
            var left = Invert(node.Left);
            var right = Invert(node.Right);

            node.Right = left;
            node.Left = right;

            return node;
        }

        public bool Equals(Node other)
        {
            return Equal(Root, other);
        }

        private bool Equal(Node main, Node other)
        {
            if (main == null && other == null)
            {
                return true;
            }
            if (main != null && other != null)
            {
                return main.Value == other.Value && Equal(main.Left, other.Left) && Equal(main.Right, other.Right);
            }

            return false;
        }

        public bool isThisABinarySearchTree()
        {
            return isThisABinarySearchTree(Root, int.MinValue, int.MaxValue);
        }

        private bool isThisABinarySearchTree(Node node, int min, int max)
        {
            if (node == null)
            {
                return true;
            }

            if (node.Value < min && node.Value > max)
            {
                return false;
            }

            return isThisABinarySearchTree(node.Left, min, node.Value) && isThisABinarySearchTree(node.Right, node.Value, max);

        }

        public List<Node> Knodes(int k)
        {
            var list = new List<Node>();
            Knodes(list, Root, k);
            return list;
        }

        private void Knodes(List<Node> nodes, Node node, int k)
        {
            if (node == null)
            {
                return;
            }

            if (k == 0)
            {
                nodes.Add(node);
                return;
            }
            Knodes(nodes, node.Left, k - 1);
            Knodes(nodes, node.Right, k - 1);

        }

        public void Breathfirst()
        {
            Breathfirst(Root);
        }

        private void Breathfirst(Node node)
        {
            var height = Height(node);

            for (int i = 0; i <= height; i++)
            {
                var list = Knodes(i);

                foreach (var item in list)
                {
                    Console.WriteLine(item.Value);
                }
            }
        }
    }
}

