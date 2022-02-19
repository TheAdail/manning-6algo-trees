using System;

namespace Binary_Node_1
{
    public class BinaryNode<T>
    {
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

        public String ValueOrNull(BinaryNode<T> node)
        {
            return node == null ? "null" : node.Value.ToString();
        }

        public override String ToString()
        {
            return $"{ValueOrNull(this)}: {ValueOrNull(LeftChild)} {ValueOrNull(RightChild)}";
        }
    }
}
