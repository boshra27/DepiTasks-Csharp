namespace Csharp06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problem: Struct Point Constructor default and parameterized
            //Point P1 = new Point();
            //Point P2 = new Point(5, 5);
            //Console.WriteLine(P1.ToString());
            //Console.WriteLine(P2.ToString());
            #endregion

            #region Question: Why Can't Struct inherit
            // Because every struct would need a virtual memory table and that would cause
            // memory bloat, if you tried to pass a BigStruct into a variable expecting a 
            // SmallStruct the extra data would be sliced off becaue value types are copied by
            // value, not by reference
            #endregion

            #region Problem: Class TypeA
            //TypeA A1 = new TypeA();
            //Console.WriteLine(A1.H);// Always accessible
            //Console.WriteLine(A1.G);// accessible only in the same project
            ////Console.WriteLine(A1._f); // accessible only in the same class
            #endregion

            #region Question: Modifiers Scope
            // public is accessible from any code in any assembly
            // private is only accessible in it's class/struct
            // protected is accessible to the class and it's children
            // internal is accessible in the same namespace/project/assembly
            // protected internal accessible from the same assembly or derived
            // class in different assembly
            // private protected accessible from a derived class in the same assembly
            #endregion

            #region Problem: Struct Employee
            //Employee Emp1 = new Employee();

            //Emp1.SetName("A");
            //Console.WriteLine(Emp1.GetName());

            //Emp1.Salary = 10;
            //Console.WriteLine(Emp1.Salary);

            //Emp1.EmpId = 1;
            //Console.WriteLine(Emp1.EmpId);
            #endregion

            #region Question: Why Encapulation?
            // Validation: we can prevent invalid data using set
            // Hiding Complexity: user doesn't know how it's stored 
            // Maintainability: If we want to change _empid we only have 
            // to change it inside the struct
            // Security: Prevent external code from corrupting your object
            #endregion

            #region Problem: Struct Point Constructor overloading
            //Point P1 = new Point(3,6);
            //Point P2 = new Point(4);
            //Console.WriteLine(P1.DisplayPoint());
            //Console.WriteLine(P2.DisplayPoint());
            #endregion

            #region Question: Constructors in struct
            // Mandatory Initialization to values, struct has a default constructor
            // where fields get intialized to default value in it.
            #endregion

            #region Problem: ToString custom formatting
            //List<Point> points = new List<Point>
            //{
            //    new Point(5, 6),
            //    new Point(3,4),
            //    new Point(4,5)
            //};

            //foreach (Point point in points) 
            //{
            //    Console.WriteLine(point.ToString());
            //}
            #endregion

            #region Question: Overriding improves readability
            // Becaue it makes output understandable ex: (3,4) instead of Csharp06.Point,
            // cleaner code as you doesn't have to manually format strings every time you want to print and object,
            // easier debugging as ToString is often used to show object state during debugging sessions
            #endregion


            // ----------------------- Part02 -----------------------
            #region What is copy constructor
            // It's a constructro used to create an new object from an existing object from the same
            // class it ensures that it's a deep copy (new instance with same values) rather than a 
            // shallow copy (two references to the same memory address)
            #endregion

            #region What is Indexer, when used, as business mention cases u have to utilize it?
            // It allows an object to be indexed just like an array. It uses this keyword and allows
            // accessing to internal collections without exposing the collection itself, it used in 
            // financial portfolio: accessing a specific stok by its symbol instead of searching list 
            // manually, translation/localizaton engine: accessing a UI string by it's key
            #endregion

            #region Summarize keywords we have learnt last lecture
            // struct: Defines a value type,
            // override: modify implementation of an inherited method,
            // set: assign value to the property and uses value keyword,
            // value: is the data being assigned to the property
            // get: returns value of a property,
            // public is accessible from any code in any assembly
            // private is only accessible in it's class/struct
            // protected is accessible to the class and it's children
            // internal is accessible in the same namespace/project/assembly
            // protected internal accessible from the same assembly or derived
            // class in different assembly
            // private protected accessible from a derived class in the same assembly
            #endregion
        }
    }
}
