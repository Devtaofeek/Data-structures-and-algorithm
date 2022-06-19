using System;

namespace Data_structures_and_algorithm.Tree
{
    /*
The heap is filled from left to right,  the children of the root must all be less than or equal to the root
a heap is a complete binary tree that satisfies the heap property.
every level in a heap must be completely filled except potentially the the last level
applications of heaps
1. sorting (heap sort)
2. heaps can be used in a graph algorithm. (shortest path)
3. heaps are also used to implement priority queus.

the height of a tree is Ologn
in heap we can only remove the root node.
we usually use an array to implement a heap even though a heap is a binary tree, they do not have hole in them, so it is effiient to use an array to implement them

	we can store the nodes in an array,
	left = parent * 2 + 1;
	right = parent * 2 + 2;
	parent = (index - 1)/2;

	// we always remove the root node
	 */
    public class Heap
    {
        int[] Items;
        int count = 0;

        public Heap(int size)
        {
            Items = new int[size];
        }

        public void Insert(int value)
        {
            if (count == Items.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            Items[count++] = value;
            BubbleUp();
        }

        private void BubbleUp()
        {

            var index = count - 1;
            while (index > 0 && Items[index] > Items[getParentIndex(index)])
            {
                Swap(index, getParentIndex(index));
                index = getParentIndex(index);
            }
        }

        private void Swap(int first, int second)
        {
            var temp = Items[first];
            Items[first] = Items[second];
            Items[second] = temp;
        }

        private int getParentIndex(int index)
        {
            return (index - 1) / 2;
        }

        public int Remove()
        {
            var index = count - 1;
            var root = Items[0];
            Items[0] = Items[index];
            BubbleDown();
            count = count - 1;
            return root;
        }

        private void BubbleDown()
        {
            var parent = 0;
            while (parent <= count && !isParentValid(parent))
            {
                Swap(parent, getLargerChildIndex(parent));
                parent = getLargerChildIndex(parent);
            }
        }

        int getLargerChildIndex(int parent)
        {
            if (!hasLeftChild(parent))
            {
                return parent;
            }

            if (!hasRightChild(parent))
            {
                return leftChild(parent);
            }
            return Items[leftChild(parent)] > Items[rightChild(parent)] ? leftChild(parent) : rightChild(parent);
        }
        private bool isParentValid(int parent)
        {
            if (!hasLeftChild(parent))
            {
                return true;
            }

            if (!hasRightChild(parent))
            {
                return Items[parent] >= Items[leftChild(parent)];
            }
            return Items[parent] >= Items[leftChild(parent)] && Items[parent] >= Items[rightChild(parent)];
        }
        private int leftChild(int parent)
        {
            return parent * 1 + 1;
        }

        private int rightChild(int parent)
        {
            return parent * 1 + 2;
        }

        bool hasLeftChild(int parent)
        {
            if (leftChild(parent) <= count)
            {
                return true;
            }
            return false;
        }

        bool hasRightChild(int parent)
        {
            if (rightChild(parent) <= count)
            {
                return true;
            }
            return false;
        }
        public bool isEmpty()
        {
            return count == 0;
        }
    }
}

