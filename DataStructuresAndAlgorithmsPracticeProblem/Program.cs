using System;

namespace DataStructuresAndAlgorithmsPracticeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter \n1. Permutations of a String" +
                                    "\n2. Binary Search A Word");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    PermutationsOfAString.StringInput();
                    break;

                case 2:
                    BinarySearchAWord.StringInput();
                    break;
            }
        }
    }
}
