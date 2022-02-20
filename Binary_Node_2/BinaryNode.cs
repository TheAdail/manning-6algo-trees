using System;
using System.Text;

namespace Binary_Node_2
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
    }
}
