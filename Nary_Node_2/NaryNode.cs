using System;
using System.Collections.Generic;
using System.Text;

namespace Nary_Node_2
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

    }
}
