// Code written by Gilbert Mfitundinda
//February/26/2021
//Primenumbercheck
using System.Linq;
using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a two dimensional array with two rows and three columns
            int[,] int2DArray = new int[2, 3];
            Console.Write("Enter 2D Array Elements : ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int2DArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int index = 0;

            //Number of rows for the two dimesnional array 
            int NoOfRows = int2DArray.GetLength(0);

            //Number of columns for the two dimensional array
            int NoOfColumns = int2DArray.GetLength(1);

            //Creating a one dimensional array 
            //By multiplying NoOfRows and NoOfColumns of the two dimensional array
            int[] OneDimensionalArray = new int[NoOfRows * NoOfColumns];

            //Assigning the elements to one dimensional array 
            //From the two dimensional array
            for (int y = 0; y < NoOfRows; y++)
            {
                for (int x = 0; x < NoOfColumns; x++)
                {
                    OneDimensionalArray[index] = int2DArray[y, x];
                    index++;
                }
            }

            //Printing the 1d array elements
            Console.WriteLine("1D Array Elements : ");
            foreach (int item in OneDimensionalArray)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();
        }
    }
}