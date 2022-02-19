using System;

namespace Binary_Node_1
{
    class Program
    {
        static void PrintStringTree(BinaryNode<String> node, bool printNode = false)
        {
            if(node != null)
            {
                if(printNode)
                    Console.WriteLine(node);
                if(node.LeftChild != null)
                    Console.WriteLine(node.LeftChild);
                if(node.RightChild != null)
                    Console.WriteLine(node.RightChild);
                PrintStringTree(node.LeftChild);
                PrintStringTree(node.RightChild);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree\n");

            BinaryNode<String> root =
                new BinaryNode<String>("Root",
                    new BinaryNode<String>("A",
                        new BinaryNode<String>("C"),
                        new BinaryNode<String>("D")
                    ),
                    new BinaryNode<String>("B",
                        null,
                        new BinaryNode<String>("E",
                            new BinaryNode<String>("F")
                        )
                    )
                );

            PrintStringTree(root, true);
        }
    }
}
