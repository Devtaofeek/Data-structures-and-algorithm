using System;

namespace Data_structures_and_algorithm.Tree
{
    public class AvlTreee
    {
        /*
 for a tree to be balanced, the difference between the height of the left and right subtree must be less than or equal to one.
we have a right skewed three in which most of the nodes only have the right child 
we have a lefr skewed three  in which most of the nodes only have the left child  
AVl trees are self balancing trees. (Aldelson vesky and landis)
red black trees
btrees
splay trees
2-2 trees
how avl tress rebalance themselves everytime we add or remove nodes, they do this by making sure the 
difference between the height of the left and right subtree is less than or equal to three

different types of rotation and how they work

left rotation
right rotation
left right 
right left


left rotaion puts a weght on the unbalanced tree and make it a right child, if the unbalanced side is the left, most times this happens when the values are sorted in ascending order. also it only consiste of only left nodes 
right rotation puts a weight on the unbalanced tree and make it a left child, the the unbalanced side is the right, most times this occur when the values are sorted in decsending order , aslo it only consite of right nodes 
left right rotation is a bit complicated cause it consist of a mix of left and right nodes,
        */
        public class AvlNode
        {

            public AvlNode(int value)
            {
                Value = value;
            }
            public int Value { get; set; }
            public AvlNode LeftChild { get; set; }
            public AvlNode RightChild { get; set; }
            public int Height { get; set; }

            public override string ToString()
            {
                return $"Node{Value}";
            }
        }

        public AvlNode Root { get; set; }

        public void Insert(int value)
        {
            Root = Insert(Root, value);
        }

        private AvlNode Insert(AvlNode root, int value)
        {
            if (root == null)
            {
                return new AvlNode(value);
            }
            if (value > root.Value)
            {
                root.RightChild = Insert(root.RightChild, value);
            }
            else
            {
                root.LeftChild = Insert(root.LeftChild, value);
            }
            setHeight(root);
            BalanceNode(root);
            return root;
        }

        void setHeight(AvlNode node)
        {
            node.Height = Math.Max(GetHeight(node.LeftChild), GetHeight(node.RightChild)) + 1;

        }
        private int GetHeight(AvlNode node)
        {
            return node == null ? -1 : node.Height;
        }

        private AvlNode BalanceNode(AvlNode root)
        {
            if (IsNodeRightHeavy(root))
            {
                if (Balancefactor(root.RightChild) > 0)
                {
                    RightRotation(root.RightChild);
                }
                LeftRotation(root);
            }
            else if (IsNodeLeftHeavy(root))
            {
                if (Balancefactor(root.LeftChild) < 0)
                {
                    LeftRotation(root.LeftChild);
                }
                RightRotation(root);
            }

            return root;
        }

        private bool IsNodeRightHeavy(AvlNode root)
        {
            return Balancefactor(root) <= -1;
        }

        private bool IsNodeLeftHeavy(AvlNode root)
        {
            return Balancefactor(root) >= 1;
        }
        private int Balancefactor(AvlNode node)
        {
            return GetHeight(node.LeftChild) - GetHeight(node.RightChild);
        }

        private AvlNode RightRotation(AvlNode node)
        {
            var newroot = node.LeftChild;
            node.LeftChild = newroot.RightChild;
            newroot.RightChild = node;
            setHeight(node);
            setHeight(newroot);
            return newroot;
        }

        private AvlNode LeftRotation(AvlNode node)
        {
            var newRoot = node.RightChild;
            node.RightChild = newRoot.RightChild;
            newRoot.LeftChild = node;
            setHeight(node);
            setHeight(newRoot);
            return newRoot;
        }
    }
}

