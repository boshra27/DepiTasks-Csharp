using System;

namespace Csharp05
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Problem: DivideByZeroException Handling
            //Console.WriteLine("Enter two numbers: ");
            //Console.WriteLine("Enter the first number: ");
            //try
            //{
            //    int X = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter the second number");
            //    int Y = int.Parse(Console.ReadLine());

            //    int Result = X / Y;
            //    Console.WriteLine($"The Result is {Result}");
            //}
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot Divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //}
            #endregion

            #region Question: Finally block purpose
            // It's used for guaranteed exectution, resource cleanup as we can release
            // resources that were allocated in the try block and state restoration
            // and logging to log actions that must be recorded
            #endregion

            #region Problem: TestDefensive Code
            //TestDefensiveCode();
            #endregion

            #region Question: TryParse robustness
            // It handles invalid data without exceptions which makes it 
            // better at performance
            #endregion

            #region Problem: nullability
            //int? X = null;
            //int Y = X ?? 0;
            //if (X.HasValue)
            //{
            //    Console.WriteLine($"The value is {X.Value}");
            //}
            //else
            //{
            //    Console.WriteLine($"X is null");
            //}
            #endregion

            #region Question: Exception when accessing Value on a null
            // InvalidOperationException nullable object must have a value
            #endregion

            #region Problem: IndexOutOfRangeException
            //int[] X = new int [5];

            //try
            //{
            //    X[5] = 10;
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Index is out of range");
            //}
            #endregion

            #region Question: Checking Array bounds
            // To avoid an IndexOutOfRangeException being thrown
            #endregion

            #region Problem: 2D Array
            //int[,] Numbers = new int[3, 3];

            //for (int i = 0; i < Numbers.GetLength(0); i++) 
            //{
            //    Console.WriteLine($"Enter the Elements of the {i+1}st row");
            //    for (int j = 0; j < Numbers.GetLength(1); j++) 
            //    {
            //        Console.WriteLine($"Enter the {j+1}st Element in the {i+1}st row");
            //        Numbers[i,j]= int.Parse( Console.ReadLine() );
            //    }
            //}

            //for (int i = 0; i < Numbers.GetLength(0); i++) 
            //{ 
            //    int SumRow = 0;
            //    for (int j = 0; j < Numbers.GetLength(1); j++) 
            //    {
            //        SumRow += Numbers[i, j];

            //    }
            //    Console.WriteLine($"The Sum of row {i+1} is {SumRow}");

            //}

            //for(int j = 0; j < Numbers.GetLength(1); j++) 
            //{ 
            //    int SumCol= 0;
            //    for(int i =0;  i < Numbers.GetLength(0); i++)
            //    {
            //        SumCol += Numbers[i, j];
            //    }
            //    Console.WriteLine($"The sum of column {j+1} is {SumCol}");
            //}

            #endregion

            #region Question: GetLength
            // It gets the length of a specific dimension of the array
            // GetLength(0) gets it's first dimension length
            #endregion

            #region Problem: Jagged Array
            //int[][] Jagged = new int [3][];
            //Jagged[0] = new int[2];
            //Jagged[1] = new int[3];
            //Jagged[2] = new int[4];

            //for (int i = 0; i < Jagged.Length; i++)
            //{
            //    for (int j = 0; j < Jagged[i].Length; j++)
            //    {
            //        Console.WriteLine($"Enter value row {i + 1} and column {j + 1} ");
            //        Jagged[i][j] = int.Parse(Console.ReadLine());
            //    }

            //}

            //for (int i = 0; i < Jagged.Length; i++) 
            //{
            //    Console.Write($"Row {i + 1}: ");
            //    foreach (int val in Jagged[i]) 
            //    { 
            //        Console.Write (val + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Question: Rectangular vs Jagged Arrays
            // Rectangular arrays are allocated as a single contiguous block of 
            // memory while jagged arrayes are array of arrays the main array holds
            // references to the array objects, each row is its own independent object
            // this result in rectangular arrays having better performance
            #endregion

            #region Problem: nullable reference types
            //string? UserInput;
            //string? RawInput = Console.ReadLine();

            //if (!string.IsNullOrWhiteSpace(RawInput))
            //    UserInput = RawInput;
            //else
            //    UserInput = null;

            //string NotNullString = UserInput!;

            #endregion

            #region Question: Purpose of nullable refence types
            // It's main purpose is intent and safety, the compiler warns if
            // you try to use a variable that might be null, better code documentation
            // and it reduces bugs as it forces handling of null cases
            #endregion

            #region Problem: Boxing
            //int X = 5;
            //object BoxedX = X;

            //try
            //{
            //    int Unboxed = (int)BoxedX;
            //    Console.WriteLine($"Successfully unboxed");
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine(ex);
            //}


            #endregion

            #region Question: Boxing and Unboxing performance impact
            // They are computationally expensive for three main reasons, memory allocation 
            // as boxing require new object to be allocated in heap, data must be copiedd from
            // stack to heap or vice versa, Garbage Collector has to clean up temporary heap allocations
            #endregion

            #region Problem: SumAndMultiply
            //SumAndMultiply(10,2, out int ResultSum, out int ResultProduct);
            //Console.WriteLine($"Sum: {ResultSum}");
            //Console.WriteLine($"Product: {ResultProduct}");
            #endregion

            #region Question: out parameters initialized inside method
            // To ensure calling code will never receive an empty value
            #endregion

            #region Problem: Optional parameter
            //Repeat("Hi!");
            //Repeat(Num: 3, X: "Named Hi!");
            #endregion

            #region Question: Optional parameters last
            // To prevent ambiguity for the compiler so it would know which one is 
            // is intended to be skipped
            #endregion

            #region Problem: null propagation operator
            //int[]? NullableArray = null;
            //int? Length = NullableArray?.Length;

            //Console.WriteLine(Length.HasValue ? $"Size is {Length}": "Array is null");

            #endregion

            #region Question: null propagation operator preventing NullReferenceException
            // It prevents a NUllReferenceException by performing a short-circuit check
            // it checks if the object is null if it's it stops executing and returns null
            #endregion

            #region Problem: Day of Week
            //Console.WriteLine($"Enter the Day of the week (1 - 7) : ");
            //int DayNum = int.Parse(Console.ReadLine());

            //switch (DayNum)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Enter a valid number");
            //        break;
            #endregion

            #region Question: switch over if statment  
            // When the number of statments > 5 testing single variables against
            // dicrete values (int, string, or enums)
            #endregion

            #region Problem: params
            //int Sum1 = SumArray(3, 5, 6, 9);
            //int Sum2 = SumArray(new int[] { 1, 2 });
            #endregion

            #region Question: Param limitations
            // It must be the last parameter in method signature, only one param per method,
            // accepts only single-dimensional array, no modifiers(ref, in, out)
            #endregion

            // -------------- Part 02 -------------------

            #region Program: Numbers in Range
            //Console.WriteLine("Enter a number as an end of range");
            //int X = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= X; i++) 
            //{
            //    Console.Write($"{i}, ");
            //}
            #endregion

            #region Program: Multipication Table
            //Console.WriteLine("Enter a number for Mulitplication Table");
            //int Num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++) 
            //{
            //    Console.Write($"{i*Num}, ");
            //}
            #endregion

            #region Program: Even Numbers
            //Console.WriteLine($"Enter a Number: ");
            //int X = int.Parse( Console.ReadLine() );

            //for (int i = 1; i <= X; i++) 
            //{ 
            //    if(i%2 == 0)
            //    {
            //        Console.WriteLine($"{i}, ");
            //    }            
            //}
            #endregion

            #region Program: Exponentiation
            //Console.WriteLine("Enter the base number: ");
            //int Base = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the power number: ");
            //int Power = int.Parse(Console.ReadLine());
            //int Result = 1 ;
            //for(int i=0; i<Power; i++)
            //{
            //    Result *= Base;
            //}
            //Console.WriteLine(Result);
            #endregion

            #region Program: Reverse a Text String
            //Console.WriteLine("Enter a string to be reversed");
            //string Str = Console.ReadLine();
            //for (int i = Str.Length-1; i >= 0; i--) 
            //{
            //    Console.Write(Str[i]);
            //}
            #endregion

            #region Program: Reverse an Integer
            //Console.WriteLine("Enter an Number to be reversed");
            //int Num = int.Parse(Console.ReadLine());
            //int LastDigit;
            //int ReversedNum =0;
            //while(Num != 0)
            //{
            //    LastDigit = Num % 10;
            //    ReversedNum = (ReversedNum * 10) + LastDigit;
            //    Num = Num / 10;
            //}
            //Console.WriteLine(ReversedNum);
            #endregion

            #region Program: Longest Distance Between Matching Elements
            //int[] Nums = { 7, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3};
            //int MaxDistance =0;

            //for (int i = 0; i < Nums.Length; i++)
            //{
            //    for (int j = Nums.Length - 1; j > i; j--) 
            //    {
            //        if (Nums[i] == Nums[j])
            //        {
            //            int Distance = j - i - 1;

            //            if (Distance > MaxDistance)
            //            {
            //                MaxDistance = Distance;
            //            }
            //            break;
            //        }

                    
            //    }
            //}
            //Console.WriteLine(MaxDistance);
            #endregion

            #region Program: Reverse Words in Sentence
            //Console.WriteLine("Write a Sentence");
            //string Sentence = Console.ReadLine();
            //string[] Words = Sentence.Split(" ");
            //string ReversedSentence ="" ;

            //for (int i = Words.Length - 1; i >= 0; i--) 
            //{
            //    ReversedSentence +=$"{Words[i]} " ;
            //}
            //Console.WriteLine(ReversedSentence);
            #endregion

        }



        #region Problem: params
        //static int SumArray(params int[] Numbers)
        //{
        //        int sum = 0;
        //        foreach (int i in Numbers) 
        //        {
        //            sum += i;
        //        }
        //        return sum;
        //}
        #endregion

        #region Problem: Optional parameter
        //static void Repeat(string X, int Num = 5)
        //{
        //    for (int i = 0; i < Num; i++)
        //    {
        //        Console.WriteLine(X);
        //    }
        //}
        #endregion

        #region Problem: SumAndMultiply
        //static void SumAndMultiply(int X, int Y, out int Sum, out int Product)
        //{
        //    Sum = X + Y;
        //    Product = X * Y;
        //}
        #endregion

        #region Problem: TestDefensiveCode
        //public static void TestDefensiveCode()
        //{
        //    int X, Y, Z;
        //    bool flag;
        //    do
        //    {
        //        Console.WriteLine("Enter first Number : ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out X) || X <= 0);
        //    do
        //    {
        //        Console.WriteLine("Enter Second Number : ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

        //    Z = X / Y;

        //    int[] arr = { 1, 2, 3 };
        //    if (arr?.Length > 69)
        //        arr[69] = 90;
        //}
        #endregion
    }
}