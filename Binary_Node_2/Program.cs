using System;

namespace Binary_Node_2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree\n");

            BinaryNode<String> a =
                new BinaryNode<String>("A",
                    new BinaryNode<String>("C"),
                    new BinaryNode<String>("D")
                );

            BinaryNode< String> root =
                new BinaryNode<String>("Root",
                    a,
                    new BinaryNode<String>("B",
                        null,
                        new BinaryNode<String>("E",
                            new BinaryNode<String>("F")
                        )
                    )
                );

            Console.WriteLine(root.ToString());
            Console.WriteLine();
            Console.WriteLine(a.ToString());
        }
    }
}
