using System;
using System.Collections.Generic;

namespace Nary_Node_4
{
    class Program
    {
        static void PrintList(string header, List<NaryNode<String>> list)
        {
            Console.Write($"{header + ":",-15}");
            foreach (NaryNode<String> node in list)
                Console.Write(node.Value + " ");
            Console.WriteLine();
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

            PrintList("Preorder", root.TraversePreorder());
            PrintList("Postorder", root.TraversePostorder());
            PrintList("Breadth First", root.TraverseBreadthFirst());
        }
    }
}
