using System;

namespace Data_structures_and_algorithm.Tree
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

        public override string ToString()
        {
            return $"Node {Value}";
        }
    }

    public class AvlNode
    {
        public AvlNode(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
        public int Height { get; set; }
        public AvlNode Left { get; set; }
        public AvlNode Right { get; set; }

        public override string ToString()
        {
            return $"Node {Value}";
        }
    }
}

