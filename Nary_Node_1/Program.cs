using System;
using System.Collections.Generic;

namespace Nary_Node_1
{
    class Program
    {
        static void PrintStringTree(NaryNode<String> node, bool printNode = false)
        {
            if (node != null)
            {
                if (printNode)
                    Console.WriteLine(node);
                foreach (NaryNode<String> child in node.Children)
                    Console.WriteLine(child);
                foreach (NaryNode<String> child in node.Children)
                    PrintStringTree(child, false);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("N-ary Tree\n");

            NaryNode<String> root =
                new NaryNode<String>("Root", new List<NaryNode<String>>() {
                    new NaryNode<String>("A", new List<NaryNode<String>>() {
                        new NaryNode<String>("D", new List<NaryNode<String>>() {
                            new NaryNode<String>("G")
                        }),
                        new NaryNode<String>("E")
                    }),
                    new NaryNode<String>("B"),
                    new NaryNode<String>("C", new List<NaryNode<String>>() {
                        new NaryNode<String>("F", new List<NaryNode<String>>() {
                            new NaryNode<String>("H"),
                            new NaryNode<String>("I")
                        })
                    })
                });

            PrintStringTree(root, true);
        }
    }
}
