using System;

namespace Binary_Node_3
{
    class Program
    {

        static void FindValue(BinaryNode<String> node, string value)
        {
            BinaryNode<String> result = node.FindNode(value);
            if (result == null)
                Console.WriteLine($"Value {value} not found");
            else
                Console.WriteLine($"Found {result.Value}");
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

            FindValue(root, "Root");
            FindValue(root, "E");
            FindValue(root, "F");
            FindValue(root, "Q");
            FindValue(b, "F");
        }
    }
}
