using System;
using System.Collections.Generic;

namespace Nary_Node_3
{
    class Program
    {
        static void FindValue(NaryNode<String> node, string value)
        {
            NaryNode<String> result = node.FindNode(value);
            if (result == null)
                Console.WriteLine($"Value {value} not found");
            else
                Console.WriteLine($"Found {result.Value}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("N-ary Tree\n");

            NaryNode<String> a = new NaryNode<String>("A", new List<NaryNode<String>>() {
                        new NaryNode<String>("D", new List<NaryNode<String>>() {
                            new NaryNode<String>("G")
                        }),
                        new NaryNode<String>("E")
                    });

            NaryNode<String> c = new NaryNode<String>("C", new List<NaryNode<String>>() {
                        new NaryNode<String>("F", new List<NaryNode<String>>() {
                            new NaryNode<String>("H"),
                            new NaryNode<String>("I")
                        })
                    });

            NaryNode <String> root =
                new NaryNode<String>("Root", new List<NaryNode<String>>() {
                    a,
                    new NaryNode<String>("B"),
                    c
                });

            FindValue(root, "Root");
            FindValue(root, "E");
            FindValue(root, "F");
            FindValue(root, "Q");
            FindValue(c, "F");
        }
    }
}
