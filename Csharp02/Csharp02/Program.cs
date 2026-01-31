using System.IO;

namespace Csharp02
{
    class program
    {
        static void Main()
        {
            #region Problem: single and multiline comments
            //single line is used to comment only one line while multi - line comment
            //is used for multiple lines
            //int x = 10;
            /*int y = 20;
            int sum = x + y;
            Console.WriteLine(sum); 
            */
            #endregion

            #region Question: comment and uncomment shortcut
            // ctrl,k,c and ctrl,k,u
            #endregion

            #region Question: runtime vs logical error
            /*runtime error accours when the program is running like division by zero
            while logical error is program not behaving as intended 
            */
            #endregion

            #region Problem: variables with proper naming coventions
            //string FullName;
            //int Age;
            //decimal Salary;
            //bool IsStudent;

            #endregion

            #region Question: following naming coventions
            // because it enhances code readability, maintainability and team collaboration
            #endregion

            #region Problem: reference type
            //int[] X;
            //int[] Y= { 1, 2, 3 };

            //X = Y;
            //for (int i = 0; i < X.Length; i++) {
            //Console.WriteLine(X[i]);
            //}
            #endregion

            #region Question: reference vs value types in memory allocation
            // reference type is stored in heap while value type is in stack
            #endregion

            #region Problem: simple calculator
            //int X = 15;
            //int Y = 4;

            //int Sum = X + Y;
            //int Diff = X - Y;
            //int Prod = X * Y;
            //float Div = X / Y;
            //int Remainder = X % Y;
            #endregion

            #region Qustion: output
            // 2, because this calculates the remainder and since a is smaller than b it
            // return the value of a
            #endregion

            #region Problem: check
            //int X = 4;

            //if (X > 10 && X % 2 == 0) {
            //    Console.WriteLine("X is greater than 10 and even.");
            //}
            #endregion

            #region Question: logical vs bitwise AND
            // && operates on the boolean value of the entire expression and uses short-circuit evaluation
            // & operates on individual bits of integer data types always evaluate both operands
            #endregion

            #region Problem: casting
            //double X = double.Parse(Console.ReadLine());
            //// connot implicitly cast double to int
            //int IntX = (int)X;
            //Console.WriteLine(IntX);

            #endregion

            #region Question: Required explicit casting
            // because the converion is a narrowing convertion and data loss might occur 
            #endregion

            #region Problem: program
            //Console.WriteLine("Enter your age: ");
            //int Age = int.Parse(Console.ReadLine());

            //if (Age < 0)
            //{
            //    Console.WriteLine("Invalid");
            //}
            //else
            //{
            //    Console.WriteLine("valid");
            //}
            #endregion

            #region Question: exceptions
            // System.Formatexception, we can handle it using tryparse instead
            #endregion

            #region Problem: prefix vs postfix
            //int X = 5;
            //Console.WriteLine(X++);//5
            //Console.WriteLine(++X);//7
            #endregion

            #region Question: value of X
            // 7, because we added 1 to x twice, once in prefix and the other in postfix
            #endregion

            #region Part02: 2
            /* compiled languages translates code to machine code as a whole while interpreted languages translates it
             code line by line C# is considered a compiled language
            */
            #endregion

            #region Part02: 3
            /* implicit casting is done automatically and does not need special synatx
               explicit casting is done manually and needs a type operator
               parse is a method inside the data types definition
               Convert is a class containing the parse methods
             */
            #endregion
        }
    }
}