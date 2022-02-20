using System;
using System.Collections.Generic;
using System.Text;

namespace Nary_Node_4
{
    public class NaryNode<T>
    {
        internal static String Indentation = "  ";
        internal T Value;
        internal List<NaryNode<T>> Children;

        public NaryNode(T value, List<NaryNode<T>> children = null)
        {
            SetThis(value, children);
        }

        public NaryNode(NaryNode<T> parent, T value, List<NaryNode<T>> children = null)
        {
            SetThis(value, children);
            if (parent != null)
                parent.AddChild(this);
        }

        internal void SetThis(T value, List<NaryNode<T>> children = null)
        {
            this.Value = value;
            this.Children = new List<NaryNode<T>>();
            if (children != null)
                this.Children.AddRange(children);
        }

        public void AddChild(NaryNode<T> node)
        {
            Children.Add(node);
        }

        public override String ToString()
        {
            return this.ToString(0);
        }

        public string ToString(int level)
        {
            string baseIndentation = level > 0 ? new StringBuilder("").Insert(0, Indentation, level).ToString() : "";
            string result = $"{baseIndentation}{this.Value}:\n";
            StringBuilder list = new StringBuilder();
            foreach (NaryNode<T> child in Children)
                list.Append(child.ToString(level+1));
            return result + list.ToString();
        }

        public NaryNode<T> FindNode(T value)
        {
            if (Value.Equals(value))
                return this;

            NaryNode<T> result = null;
            foreach(NaryNode<T> child in Children)
            {
                result = child.FindNode(value);
                if (result != null)
                    break;
            }
            return result;
        }

        public List<NaryNode<T>> TraversePreorder()
        {
            List<NaryNode<T>> result = new List<NaryNode<T>>() { this };
            foreach(NaryNode<T> child in Children)
                result.AddRange(child.TraversePreorder());
            return result;
        }

        public List<NaryNode<T>> TraversePostorder()
        {
            List<NaryNode<T>> result = new List<NaryNode<T>>();
            foreach (NaryNode<T> child in Children)
                result.AddRange(child.TraversePostorder());
            result.Add(this);
            return result;
        }

        public List<NaryNode<T>> TraverseBreadthFirst(bool addNode = true)
        {
            List<NaryNode<T>> result = new List<NaryNode<T>>();
            if (addNode)
                result.Add(this);
            foreach (NaryNode<T> child in Children)
                result.Add(child);
            foreach (NaryNode<T> child in Children)
                result.AddRange(child.TraverseBreadthFirst(false));
            return result;
        }

    }
}
