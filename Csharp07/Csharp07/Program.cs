using System.Globalization;
using System.Security.Cryptography;

namespace Csharp07
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            #region Problem: Class Car
            //Car C1 = new Car();
            //Car C2 = new Car(1);
            //Car C3 = new Car(2, "Nissan");
            //Car C4 = new Car(98, "Renault", 500000);

            //Console.WriteLine(C1.ToString());
            //Console.WriteLine(C2.ToString());
            //Console.WriteLine(C3.ToString());
            //Console.WriteLine(C4.ToString());

            #endregion

            #region Question: Custom constructor suppress default
            // It's for type safety and intent:if a constructor is written with specific parameters
            // it tells the compiler that this object needs this specific data, if the compiler kept
            // the default constructor someone might create a black object that bypasses required 
            // intialization, It forces you to be intentional, you need to manully type it

            #endregion

            #region Problem: Class Calculator
            //Calculator Cal1 = new Calculator();
            //Console.WriteLine(Cal1.Sum(2, 6));
            //Console.WriteLine(Cal1.Sum(2, 6, 8));
            //Console.WriteLine(Cal1.Sum(2.3, 6.2));
            #endregion

            #region Question: Overloading for code readability and reusability
            // readbility: it provides consistency as developers have to remember one name, reduces
            // cognitive load because you don't care if you're passing an integer or double,
            // reusability: It provides flexibility for the caller where you can make simple and complex
            // versions of the method and it allows constructor overloading making you able to reuse
            // intialization logic



            #endregion

            #region Problem: Parent and Child Class, Product override, ToString override
            //Child C1 = new Child(5, 6, 7);
            //Console.WriteLine(C1.ToString());
            //Console.WriteLine(C1.Product());


            //Parent P1 = new Parent(4, 3);
            //Console.WriteLine(P1.ToString());
            #endregion

            #region Question: Constructor chaining in inheritance
            // It ensures that base classs initialization as a derived class canont exist without the
            // base calls being intialized first, DRY (Don't Repeat Yourself) as you don't have to copy
            // the same code into subclasses, centralizing logic as you only do changes in base class
            #endregion

            #region Question: new vs override in method overriding
            // override (Polymorphism): it's extending the base method, even if you hold a reference
            // to the object as Parent type, C# will look at the actual object at runtime, see that
            // it is a Child, and run the child's version
            // new (method hiding): i'ts hiding the base method and creating a brand-nw method with 
            // the same name
            #endregion

            #region Question: ToString often overridden
            // Simplified Debugging: The debugger often uses to string to show the value
            // of objects so without overriding you see Csharp07.Child and you have to
            // expand the object to see details but with it you see (4, 3), 
            // Seamless String Concatentation: when using object in a string context C# 
            // automatically calls ToString, overriding ensures meaningful output
            #endregion

            #region Problem: Interface IShape
            //IShape R1 = new Rectangle(4,10);
            //Console.WriteLine(R1.Draw());
            #endregion

            #region Question: Can't create instance of an interface
            // Becaue an interface is like a blueprint it has not Implementation: It as 
            // no logic. Incomplete Definition: it only provides Singatures (name and paramters)
            // and then a concrete class provides the logic
            #endregion

            #region Problem: Circle Implements IShape
            //IShape MyCircle = new Circle(5);
            //Console.WriteLine(MyCircle.Draw());
            //MyCircle.PrintDetails();
            #endregion

            #region Question: Default implementations benefits
            // It solved Backward Compatibility: before C# 8.0 every class would have to implement 
            // a new method added to the interface. It reduces repetition if most classes does a
            // sepcific function the exact same way. It provides an optional functionality that
            // classes can choose to use or ovrride.
            #endregion

            #region Problem: interface IMovable
            //IMovable MyCar = new Car();
            //Console.WriteLine(MyCar.Move());
            #endregion

            #region Question: Using interface reference to access implementing class method
            // It's better for Flexibility: The code becomes "loosely coupled". If you haave a mehtode
            // that accepts IMovable, it doesn't care if you pass car or bicycle. The object can be swapped 
            // without changing the code that uses it.
            // Plug and play architecture: IMovable can manage different type of vechicle without the need of 
            // separating logic.
            // Easier uniting testing, a "Mock" version of IMovale can be created that doesn't drive a specific 
            // class so other parts of the logic can be tested
            #endregion

            #region Problem: IReadable and IWritable interfaces
            //File MyFile = new File();

            //MyFile.Read();
            //MyFile.Write();
            #endregion

            #region Question: Overcoming single inheritance
            // A class can implement multiple interfaces without the complexity and ambiguity problems
            // of multiple class inheritance, the interfaces contains method signatures and the class 
            // implements it and provides the actual method definition
            #endregion

            #region Problem: Shape base class
            //Shape Rec1 = new Rectangle(6, 8);
            //Rec1.Draw();
            //Console.WriteLine(Rec1.CalculateArea());
            #endregion

            #region Question: Virtual vs Abstract method
            // Virtual Methode has an implementation, it's optional to override it and it does not need an
            // abstract class
            // Abstract Methode has no implementation, it must be overridden, and it needs an abstract class
            #endregion

            // --------------------- Part02 ---------------------

            #region Class vs Struct
            // Class: Reference type, stored in heap, supports inheritance, can be null, used for complex objects
            // Struct: Value type, stored in stack, doesn't support inheritance, cannot be null, used for simple objects
            #endregion

            #region Classes relations other than inheritance
            // Association: Uses-a, Ex: Student uses teacher
            // Aggreagation: Has-a, Weak ownership, Ex: A Department has teachers
            // Compostion: Has-a, strong ownership, Ex: A car has an engine
            // Dependency: Temporary relationship, Ex: Report uses printer to be printed
            #endregion

        }
    }
}
