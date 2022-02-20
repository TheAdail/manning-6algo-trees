using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Node_4
{
    public class BinaryNode<T>
    {
        internal static string Indentation = "  ";
        internal T Value;
        internal BinaryNode<T> LeftChild, RightChild;

        public BinaryNode(T Value, BinaryNode<T> Left = null, BinaryNode<T> Right = null)
        {
            this.Value = Value;
            LeftChild = Left;
            RightChild = Right;
        }

        public void AddLeft(BinaryNode<T> child)
        {
            LeftChild = child;
        }

        public void AddRight(BinaryNode<T> child)
        {
            RightChild = child;
        }

        public String ValueOrNone(BinaryNode<T> node, int level)
        {
            return node == null ? "None" : node.ToString(level);
        }

        public override String ToString()
        {
            return this.ToString(0);
        }

        public string ToString(int level)
        {
            string baseIndentation = level > 0 ? new StringBuilder("").Insert(0, Indentation, level).ToString() : "";
            string result = $"{baseIndentation}{this.Value}:\n";
            if(LeftChild != null || RightChild != null)
            {
                baseIndentation += Indentation;
                if (LeftChild == null)
                    result += $"{baseIndentation}None\n";
                else
                    result += LeftChild.ToString(level + 1);
                if (RightChild == null)
                    result += $"{baseIndentation}None\n";
                else
                    result += RightChild.ToString(level + 1);
            }
            return result;
        }

        public BinaryNode<T> FindNode(T value)
        {
            if (Value.Equals(value))
                return this;

            BinaryNode<T> result = null;

            if (LeftChild != null)
                result = LeftChild.FindNode(value);

            if (result == null && RightChild != null)
                result = RightChild.FindNode(value);

            return result;
        }

        public List<BinaryNode<T>> TraversePreorder()
        {
            List<BinaryNode<T>> result = new List<BinaryNode<T>>() { this };
            if (LeftChild != null)
                result.AddRange(LeftChild.TraversePreorder());
            if (RightChild != null)
                result.AddRange(RightChild.TraversePreorder());
            return result;
        }

        public List<BinaryNode<T>> TraverseInorder()
        {
            List<BinaryNode<T>> result = new List<BinaryNode<T>>();
            if (LeftChild != null)
                result.AddRange(LeftChild.TraverseInorder());
            result.Add(this);
            if (RightChild != null)
                result.AddRange(RightChild.TraverseInorder());
            return result;
        }

        public List<BinaryNode<T>> TraversePostorder()
        {
            List<BinaryNode<T>> result = new List<BinaryNode<T>>();
            if (LeftChild != null)
                result.AddRange(LeftChild.TraversePostorder());
            if (RightChild != null)
                result.AddRange(RightChild.TraversePostorder());
            result.Add(this);
            return result;
        }

        public List<BinaryNode<T>> TraverseBreadthFirst(bool addNode = true)
        {
            List<BinaryNode<T>> result = new List<BinaryNode<T>>();
            if (addNode)
                result.Add(this);
            if (LeftChild != null)
                result.Add(LeftChild);
            if (RightChild != null)
                result.Add(RightChild);
            if (LeftChild != null)
                result.AddRange(LeftChild.TraverseBreadthFirst(false));
            if (RightChild != null)
                result.AddRange(RightChild.TraverseBreadthFirst(false));
            return result;
        }

    }
}
