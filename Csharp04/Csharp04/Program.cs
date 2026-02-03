using System;
using System.Collections.Immutable;

namespace Csharp04
{
    public class Program
    {
        static void Main()
        {
            #region Problem: Array intialization
            //int[] arr1 = new int[3];
            //int[] arr2 = new int[3] { 1, 2, 3 };
            //int[] arr3 = { 1, 2, 3 };
            //for(int i =0; i< arr1.Length; i++)
            //{
            //    arr1[i] = i;
            //    Console.WriteLine(arr1[i]);
            //}
            ////IndexOutOfRangeException.
            //for (int i = 0; i <= arr1.Length; i++)
            //{
            //    arr1[i] = i;
            //    Console.WriteLine(arr1[i]);
            //}
            #endregion

            #region Question: Default value assigned to array elements
            // It's the default value of the data type we're using.
            #endregion

            #region Problem: Shallow and Deep Copy
            //int[] arr1 = { 1, 2, 3 };
            ////int[] arr2 = arr1;
            //int[] arr2 = (int[])arr1.Clone();
            //arr1[2] = 4;
            //Console.WriteLine(arr2[2]);

            #endregion

            #region Question: Array.Copy vs Array.Clone
            // Clone creates a new matrix while Copy requires an exiting matrix
            #endregion

            #region Problem: 2D Array
            //int[,] grades = new int[3, 3];

            //for(int i = 0; i < grades.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter the grades of Student {i + 1}");
            //    for(int j = 0; j < grades.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter subject {j+1}");
            //        grades[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for(int i = 0;i < grades.GetLength(0); i++)
            //{
            //    for(int j = 0;j < grades.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"The grades of Student {i+1} in subject {j+1} is { grades[i, j]}");
            //    }
            //}
            #endregion

            #region Question: GetLength vs Lenght
            //GetLenght gets the number of elements in a specific dimension while
            // Length gets the total number of elements
            #endregion

            #region Problem: Array Methodes
            //int[] arr1 = { 2, 7, 4, 5 };
            //Array.Sort(arr1);// Reorders array in ascending order
            //Array.Reverse(arr1);// reverses the sequence of elements
            //Array.IndexOf(arr1,4);// return 2 the first index of value 4

            //int[] destination = new int[3];
            //Array.Copy(arr1, destination, destination.Length);
            //// Copies a specified number of elements from source to destination

            //Array.Clear(arr1, 0, 2);
            //// Sets a range of element to default value [0, 0, 4, 5]
            //for (int i = 0; i < arr1.Length; i++) 
            //{
            //    Console.WriteLine(arr1[i]);
            //}

            #endregion

            #region Question: Copy vs ConstrainedCopy
            // Copy: if an error occurs during copying it leaves the destinatian partially modified
            // and it allows widening conversions int to double
            // ConstrainedCopy: if an error occurs no changes happens to destination and it requires identical types

            #endregion

            #region Problem: loops
            //int[] arr1 = { 1, 3, 4 };
            ////for (int i = 0; i < arr1.Length; i++)
            ////    Console.WriteLine(arr1[i]);
            ////foreach(int i in arr1) 
            ////    Console.WriteLine(i);
            //int i = arr1.Length - 1;
            //while(i >= 0)
            //{
            //    Console.WriteLine(arr1[i]);
            //    i--;
            //}
            #endregion

            #region Question: foreach preferred for read-only
            // Because it doesn't allow for modificatians, readability and automatic bounds
            #endregion

            #region Problem: positive odd number
            //int OddNum;
            //bool success;
            //do
            //{
            //    Console.WriteLine("Enter a postive odd number");
            //    success = int.TryParse(Console.ReadLine(), out OddNum);
            //}
            //while (!success || OddNum < 0 || OddNum % 2 == 0);

            #endregion

            #region Question: Input validation
            // Because a user can input an invalid input and
            // it needs to be handeled to avoid an exception
            #endregion

            #region Problem: Matrix format
            //int[,] Matrix =
            //{
            //    {10, 20, 30, },
            //    {40, 50, 60, },
            //    {70, 80, 90 }
            //};

            //for (int i = 0; i < Matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < Matrix.GetLength(1); j++)
            //    {
            //        Console.Write(Matrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Question: 2D array format for better readability
            // Print it in a matrix format using \t or {0, -10} 0 takes the current index
            // 10 is the number of characters reserved for each number and - means left aligned 

            #endregion

            #region Problem: Control flow
            //Console.WriteLine("Enter a month number");
            //int MonthNumber = int.Parse(Console.ReadLine());
            //if (MonthNumber == 1)
            //    Console.WriteLine("Jan");
            //else if (MonthNumber == 2)
            //    Console.WriteLine("Feb");
            //else if (MonthNumber == 3)
            //    Console.WriteLine("March");
            //else if (MonthNumber == 4)
            //    Console.WriteLine("April");
            //else if (MonthNumber == 5)
            //    Console.WriteLine("May");
            //else if (MonthNumber == 6)
            //    Console.WriteLine("June");
            //else if (MonthNumber == 7)
            //    Console.WriteLine("July");
            //else if (MonthNumber == 8)
            //    Console.WriteLine("August");
            //else if (MonthNumber == 9)
            //    Console.WriteLine("Sept");
            //else if (MonthNumber == 10)
            //    Console.WriteLine("Oct");
            //else if (MonthNumber == 11)
            //    Console.WriteLine("Nov");
            //else if (MonthNumber == 12)
            //    Console.WriteLine("Dec");

            //switch (MonthNumber) {
            //    case 1: 
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2: Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break; 
            //    case 4: 
            //        Console.WriteLine("April");
            //        break; 
            //    case 5: 
            //        Console.WriteLine("May");
            //        break; 
            //    case 6: 
            //        Console.WriteLine("June");
            //        break; 
            //    case 7: 
            //        Console.WriteLine("July");
            //        break; 
            //    case 8: 
            //        Console.WriteLine("August");
            //        break; 
            //    case 9: 
            //        Console.WriteLine("Sept");
            //        break; 
            //    case 10: 
            //        Console.WriteLine("Oct");
            //        break; 
            //    case 11: 
            //        Console.WriteLine("Nov");
            //        break; 
            //    case 12: 
            //        Console.WriteLine("Dec");
            //        break;
            //}

            #endregion

            #region Question: Switch over if-else
            // When the number of statments > 5
            #endregion

            #region Problem: Sort, IndexOf and LastIndexOf
            //int[] arr1 = { 4, 2, 5, 2 };
            //Array.Sort(arr1);
            ////Before sorting
            //Console.WriteLine(Array.IndexOf(arr1,2));// 1
            //Console.WriteLine(Array.LastIndexOf(arr1, 2));// 3
            #endregion

            #region Question: Time complexity of Array.Sort
            // nlogn
            #endregion

            #region Problem: Sum of integers
            //int[] Integers = { 1, 2, 3 };
            //int Sum = 0;
            //for (int i = 0; i < Integers.Length; i++)
            //{
            //    Sum += Integers[i];
            //}

            //foreach(int i in Integers)
            //{
            //    Sum += i;
            //}
            //Console.WriteLine(Sum);
            #endregion

            #region Question: Which is more efficient for calculating sum (for or foreach)
            // foreach: because it's higher in speed, bound checking is
            // often eliminated and no possible index errors
            #endregion

            //------- Part02 -----------

            #region 2
            //Console.WriteLine("Enter a number (1-7)");
            //string num = Console.ReadLine();

            //DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), num);

            //Console.WriteLine($"The day is {day}");
            #endregion

            #region 3
            // The number entered by user will be printed
            #endregion

        }
    }

    enum DayOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}