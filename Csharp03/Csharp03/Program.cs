using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Text;
using System.Xml.Linq;

namespace Csharp03
{
    class Program
    {
        static void Main() 
        {
            #region Problem: String to Int
            /*try
            {
                int num = int.Parse(Console.ReadLine());
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                throw;
            }*/

            #endregion

            #region Question: Parse vs Convert
            //parse throws a ArgumentNull exception while Convert returns 0
            #endregion

            #region Problem: TryParse

            /*bool success = int.TryParse(Console.ReadLine(),out int parsedNum);

            if (success) 
            {
                Console.WriteLine(parsedNum);
            }
            else
            {
                Console.WriteLine("Invalid Format");
            }*/
            #endregion

            #region Question: Tryparse over Parse
            // To be able to handle exceptions in case of occurring when user input is invalid 
            #endregion

            #region Problem: Object
            //object b1 = new object();
            //b1 = "lsdfj";
            //Console.WriteLine(b1.GetHashCode());
            //b1 = 11.2;
            //Console.WriteLine(b1.GetHashCode());

            #endregion

            #region Question: GEtHashCode()
            //It's used for performance optimization in data structures that uses hash tables 
            #endregion

            #region Problem: Changing references
            //object b1 = new object();
            //b1 = 1;
            //object b2 = b1;
            //b1 = 2;
            //Console.WriteLine(b2);

            #endregion

            #region Question: reference equality
            //It is establishes identity even if two objects have 
            //same data they're not reference equal if they're not the same instance
            #endregion


            #region Problem: Concatenating
            //string s1 = "Hello, ";
            //Console.WriteLine(s1.GetHashCode());
            //s1 += "Hi Willy";
            //Console.WriteLine(s1.GetHashCode());
            #endregion

            #region Question: immutable string
            // because It's made of an array of characters 
            #endregion

            #region Problem: StringBuilder GetHashCode

            //StringBuilder sb = new StringBuilder("Hi Willy");
            //Console.WriteLine($"{sb.GetHashCode()}");

            //sb.Append(", how are you?");
            //Console.WriteLine($"{sb.GetHashCode()}");

            #endregion

            #region Question: StringBuilder address the inefficiencies of string
            //It doesn't create a new object it changes the one we're using.
            #endregion

            #region Question: Large-scale string modificatons
            //Because it won't fill the heap with objects with no reference 
            #endregion

            #region Problem: concatenation methods
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int sum = num1 + num2;

            //Console.WriteLine("Sum is"+ num1 +"+"+ num2 + "=" + sum);
            //Console.WriteLine("Sum is {0} + {1} = {2}",num1, num2, sum);
            //Console.WriteLine($"Sum is {num1} + {num2} = {sum}");
            #endregion

            #region Question: most used string formatting method
            //String interpolation because it doesn't create new object for
            //each concatenation and it's better for readability.
            #endregion

            #region Problem: StringBuilder
            StringBuilder sb = new StringBuilder("hello world");
            sb.Append("!");
            sb.Replace("world", "everyone");
            sb.Insert(6, "there");
            sb.Remove(0, 6);

            #endregion

            #region Question: SringBuilder design
            //Stingbuilder is design to overcome immutability in string using
            //an internal buffer to handle changes in place.
            #endregion


            //Part02
            #region 2 
            //enumeration is a value type used to define named integral constants.
            //Used when variable can only take one value from a set of values.
            //Examples: System.DayOfWeek, System.Net.HttpStatusCode, System.IO.FileMode
            #endregion

            #region 3
            //string is used in simple joins 2-4 concatenation and outside of loops.
            //StringBuilder is used for complex strings with non-constant values and used in loops.
            #endregion
        }
    }
}