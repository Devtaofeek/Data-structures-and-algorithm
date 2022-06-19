using System;

namespace Data_structures_and_algorithm.Tree
{
    public class TreeBinary
    {
        public Node Root { get; set; }

        public void insert(int value)
        {
            var node = new Node(value);

            if (Root == null)
            {
                Root = node;
                return;
            }

            var current = Root;
            while (true)
            {
                if (value > current.Value)
                {
                    if (current.Right == null)
                    {
                        current.Right = node;
                        break;
                    }
                    else
                    {
                        current = current.Right;
                    }
                }
                else
                {
                    if (current.Left == null)
                    {
                        current.Left = node;
                        break;
                    }
                    else
                    {
                        current = current.Left;
                    }
                }
            }
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
                if (value == current.Value)
                {
                    return true;
                }
                else if (value > current.Value)
                {
                    current = current.Right;
                }
                else
                {
                    current = current.Left;
                }
            }
            return false;
        }

        public void Pre()
        {
            Pre(Root);
        }

        private void Pre(Node node)
        {
            if (node == null)
            {
                return;
            }

            Console.WriteLine(node.Value);
            Pre(node.Left);
            Pre(node.Right);
        }

        public void In()
        {
            In(Root);
        }
        private void In(Node node)
        {
            if (node == null)
            {
                return;
            }

            In(node.Left);
            Console.WriteLine(node.Value);
            In(node.Right);
        }

        private void Post(Node node)
        {
            if (node == null)
            {
                return;
            }
            Post(node.Left);
            Post(node.Right);
            Console.WriteLine(node.Value);
        }

        public int GetHeight()
        {
            return GetHeight(Root);
        }

        private int GetHeight(Node node)
        {
            if (node == null)
            {
                return -1;
            }

            if (node.Left == null && node.Right == null)
            {
                return 0;
            }

            return 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
        }

        public int GetMinimum()
        {
            return GetMinimum(Root);
        }
        private int GetMinimum(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.Left == null && node.Right == null)
            {
                return node.Value;
            }
            var left = GetMinimum(node.Left);
            var right = GetMinimum(node.Right);
            var value = node.Value;

            return Math.Min(Math.Min(left, right), value);
        }

        public int GetMinimumInBinarySearchtree()
        {
            return GetMinimumInBinarySearchtree(Root);
        }

        private int GetMinimumInBinarySearchtree(Node node)
        {
            if (node.Right == null && node.Left == null)
            {
                return node.Value;
            }

            var current = node;
            var left = current;

            while (current != null)
            {
                left = current;
                current = current.Left;
            }

            return left.Value;
        }

        public bool Equals()
        {
            return Equals(Root);
        }

        private bool Equals(Node node, Node other)
        {
            if (node == null && other == null)
            {
                return true;
            }

            if (node != null && other != null)
            {
                return node.Value == other.Value && Equals(node.Right, other.Right) && Equals(node.Left, other.Left);
            }

            return false;
        }


        public bool IsBinarySearchTree()
        {
            return IsBinarySearchTree(Root, int.MinValue, int.MaxValue);
        }

        private bool IsBinarySearchTree(Node rootNode, int min, int max)
        {
            if (rootNode == null)
            {
                return true;
            }

            if (rootNode.Value < min && rootNode.Value > max)
            {
                return false;
            }

            return IsBinarySearchTree(rootNode.Left, min, rootNode.Value) && IsBinarySearchTree(rootNode.Right, rootNode.Value, int.MaxValue);
        }
        public List<Node> PrintKdistance(int k)
        {
            var list = new List<Node>();
            PrintKdistance(Root, k, list);
            return list;
        }
        private void PrintKdistance(Node node, int k, List<Node> nodes)
        {
            if (node == null)
            {
                return;
            }
            if (k == 0)
            {
                Console.WriteLine(node.Value);
            }
            PrintKdistance(node.Left, k - 1, nodes);
            PrintKdistance(node.Right, k - 1, nodes);

        }

        public void Bfs()
        {
            var current = Root;
            var height = GetHeight(current);

            for (int i = 0; i <= height; i++)
            {
                var list = PrintKdistance(i);
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public Node Invert()
        {
            return Invert(Root);
        }

        private Node Invert(Node node)
        {
            if (node == null)
            {
                return node;
            }

            var left = Invert(node.Left);
            var right = Invert(node.Right);

            node.Left = right;
            node.Right = left;

            return node;
        }
    }
}



