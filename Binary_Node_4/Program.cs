using System;
using System.Collections.Generic;

namespace Binary_Node_4
{
    class Program
    {

        static void PrintList(string header, List<BinaryNode<String>> list)
        {
            Console.Write($"{header+":",-15}");
            foreach (BinaryNode<String> node in list)
                Console.Write(node.Value + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree\n");

            BinaryNode<String> a =
                new BinaryNode<String>("A",
                    new BinaryNode<String>("C"),
                    new BinaryNode<String>("D")
                );

            BinaryNode<String> b =
                new BinaryNode<String>("B",
                    null,
                    new BinaryNode<String>("E",
                        new BinaryNode<String>("F")
                    )
                );

            BinaryNode< String> root =
                new BinaryNode<String>("Root",
                    a,
                    b
                );

            PrintList("Preorder", root.TraversePreorder());
            PrintList("Inorder", root.TraverseInorder());
            PrintList("Postorder", root.TraversePostorder());
            PrintList("Breadth First", root.TraverseBreadthFirst());
        }
    }
}
