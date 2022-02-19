using System;
using System.Collections.Generic;
using System.Text;

namespace Nary_Node_1
{
    public class NaryNode<T>
    {
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

        public override string ToString()
        {
            StringBuilder list = new StringBuilder();
            foreach(NaryNode<T> child in Children)
                list.Append($"{child.Value} ");
            return $"{Value}: {list}";
        }

    }
}
