using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Node_7
{
    public class SortedBinaryNode<T> where T : IComparable<T>
    {
        internal static string Indentation = "  ";
        internal T Value;
        internal SortedBinaryNode<T> LeftChild, RightChild;

        public SortedBinaryNode(T Value, SortedBinaryNode<T> Left = null, SortedBinaryNode<T> Right = null)
        {
            this.Value = Value;
            LeftChild = Left;
            RightChild = Right;
        }

        public void AddLeft(SortedBinaryNode<T> child)
        {
            LeftChild = child;
        }

        public void AddRight(SortedBinaryNode<T> child)
        {
            RightChild = child;
        }

        public String ValueOrNone(SortedBinaryNode<T> node, int level)
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

        public void AddNode(SortedBinaryNode<T> node)
        {
            if(node.Value.CompareTo(Value) < 0)
            {
                if(LeftChild == null)
                {
                    AddLeft(node);
                }
                else
                {
                    LeftChild.AddNode(node);
                }
            }
            else
            if (node.Value.CompareTo(Value) > 0)
            {
                if (RightChild == null)
                {
                    AddRight(node);
                }
                else
                {
                    RightChild.AddNode(node);
                }
            }
        }

        public SortedBinaryNode<T> FindNode(T value)
        {
            if (Value.Equals(value))
                return this;

            SortedBinaryNode<T> result = null;

            if (value.CompareTo(Value) < 0)
            {
                if (LeftChild != null)
                    result = LeftChild.FindNode(value);
            }
            else
            {
                if (value.CompareTo(Value) > 0)
                {
                    if (RightChild != null)
                        result = RightChild.FindNode(value);
                }
            }

            return result;
        }

        public List<SortedBinaryNode<T>> TraversePreorder()
        {
            List<SortedBinaryNode<T>> result = new List<SortedBinaryNode<T>>() { this };
            if (LeftChild != null)
                result.AddRange(LeftChild.TraversePreorder());
            if (RightChild != null)
                result.AddRange(RightChild.TraversePreorder());
            return result;
        }

        public List<SortedBinaryNode<T>> TraverseInorder()
        {
            List<SortedBinaryNode<T>> result = new List<SortedBinaryNode<T>>();
            if (LeftChild != null)
                result.AddRange(LeftChild.TraverseInorder());
            result.Add(this);
            if (RightChild != null)
                result.AddRange(RightChild.TraverseInorder());
            return result;
        }

        public List<SortedBinaryNode<T>> TraversePostorder()
        {
            List<SortedBinaryNode<T>> result = new List<SortedBinaryNode<T>>();
            if (LeftChild != null)
                result.AddRange(LeftChild.TraversePostorder());
            if (RightChild != null)
                result.AddRange(RightChild.TraversePostorder());
            result.Add(this);
            return result;
        }

        public List<SortedBinaryNode<T>> TraverseBreadthFirst(bool addNode = true)
        {
            List<SortedBinaryNode<T>> result = new List<SortedBinaryNode<T>>();
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
