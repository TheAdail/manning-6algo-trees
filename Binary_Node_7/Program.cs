using System;
using System.Collections.Generic;

namespace Binary_Node_7
{
    class Program
    {

        static void PrintList(string header, List<SortedBinaryNode<int>> list)
        {
            Console.Write($"{header+":",-15}");
            foreach (SortedBinaryNode<int> node in list)
                Console.Write(node.Value + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sorted Binary Tree\n");
            Console.WriteLine("Enter: 'a n' to insert value 'n'; 'f n' to find value 'n'; 'q' to quit\n");

            SortedBinaryNode<int> root = new SortedBinaryNode<int>(-1);

            string input = " ";

            while (input != "q")
            {
                Console.Write(">");
                input = Console.ReadLine();

                try
                {
                    switch ((input + " ").ToLower()[0])
                    {
                        case 'a':
                            root.AddNode(new SortedBinaryNode<int>(Convert.ToInt32(input[2..].Trim())));
                            PrintList("Inorder", root.TraverseInorder());
                            break;

                        case 'f':
                            if (root.FindNode(Convert.ToInt32(input[2..].Trim())) == null)
                                Console.WriteLine("Value is not in the tree");
                            else
                                Console.WriteLine("Value found");
                            break;

                        case 'q':
                            input = "q";
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nError: {ex.Message}");
                }
                Console.WriteLine();
            }
        }
    }
}
