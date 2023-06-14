using System;

namespace cSharp_Evaluation01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1:
            //Write a method that takes an integer array  as an input and sorts it.
            //It's a one dimesional array. 
            //For example A = [4, 7, 3, 5, 1, 10, 90, 8] output of the array should
            //be[1, 3, 4, 5, 7, 8, 10, 90]
            int[] A = { 4, 7, 3, 5, 1, 10, 90, 8, 6 };
            Console.WriteLine("Sorting array is: ");
            //Console.WriteLine(arraySorting(A[i]));
            int elementPos = 0;
            Console.WriteLine("Enter a number to start search in the array> ");
            int searchNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The serching number is "+ searchNum + " in "+ searchingNumber(elementPos,searchNum));
        }

        //Q1: Sorting method
        //static int arraySorting(int[] A,int i)
        //{
        //    //loop from the second element to the last
        //    for (i = 0; i < A.Length - 1; i++)
        //    {
        //        // Loop the array
        //        for (int j = i+ 1; j < A.Length; j++)
        //        {
        //            if (A[i] > A[j]) // Comparing 
        //            {
        //                int num = A[i]; // Swaping elements
        //                A[i] = A[j];
        //                A[j] = num;
        //            }
        //        }

        //     return A[i];
        //    }
        //}
        //Q2:
        //Write a method to implement searching
        static int searchingNumber(int[] A, int searchNum)
        {
            for (int elementPos = 0; elementPos < A.Length; elementPos++)
            {

                if (A[elementPos] == searchNum)
                {
                    return elementPos;
                }
                else
                {
                    Console.WriteLine("-1");
                }
            }
            return -1;
        }
    }
}