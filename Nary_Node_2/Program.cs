using System;
using System.Collections.Generic;

namespace Nary_Node_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N-ary Tree\n");

            NaryNode<String> a = new NaryNode<String>("A", new List<NaryNode<String>>() {
                        new NaryNode<String>("D", new List<NaryNode<String>>() {
                            new NaryNode<String>("G")
                        }),
                        new NaryNode<String>("E")
                    });

            NaryNode<String> root =
                new NaryNode<String>("Root", new List<NaryNode<String>>() {
                    a,
                    new NaryNode<String>("B"),
                    new NaryNode<String>("C", new List<NaryNode<String>>() {
                        new NaryNode<String>("F", new List<NaryNode<String>>() {
                            new NaryNode<String>("H"),
                            new NaryNode<String>("I")
                        })
                    })
                });

            Console.WriteLine(root.ToString());
            Console.WriteLine();
            Console.WriteLine(a.ToString());
        }
    }
}
