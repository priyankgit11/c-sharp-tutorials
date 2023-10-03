using System;
namespace basics2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Circle c1 = new(12); // another way to use 
            //Console.WriteLine(c1.x);
            //List<string> names = new List<string> { "Priyank", "Ana", "Felipe" };
            //names.Add("Ayaz");
            //names.Remove("Ana");
            //Console.WriteLine(names.IndexOf("Felipe"));
            //Console.WriteLine(names.IndexOf("Dhara"));
            //foreach (string name in names)
            //{
            //    Console.WriteLine($"Hello {name}");
            //}
            //names.Sort();
            //foreach (string name in names)
            //{
            //    Console.WriteLine($"Hello {name}");
            //}
            //try
            //{
            //    if (16/4 == 4)
            //        TestThrow();
            //}
            //catch (CustomException ex) {
            //    Console.WriteLine(ex.ToString());
            //}
            //finally {
            //    Console.WriteLine("Finally Hello World");
            //}
            //CustomException c1;
            //Console.WriteLine(nameof(c1)); // c1
            //List<int> l = new List<int>(); 
            //Console.WriteLine(nameof(List<int>)); // List
            //Circle c1 = new();
            //c1.Print();//base keyword
            Circle c1 = new Circle();
            c1.draw();
        }
        //public static void TestThrow()
        //{
        //    throw new CustomException("Exception is thrown ");
        //}
    }
    //class CustomException : Exception
    //{
    //    public CustomException(string message)
    //    {
    //        Console.WriteLine(Message + ": Custome Exception");
    //    }
    //}
    //public class Circle
    //{
    //    public int x;
    //    public Circle(int ptr)
    //    {
    //        this.x = ptr;
    //    }
    //}
    //public class Shapes {
    //    public int point=12;
    //}
    //public sealed class  Circle : Shapes //sealed
    //{
    //    public int point = 14;
    //    public void Print()
    //    {
    //        Console.WriteLine(base.point);
    //    }
    //}
    //public class Sphere : Circle // can't derive due to sealed 
    //{

    //}
    //public abstract class Shapes // class need to be abstract to have abstract methods
    //{
    //    public abstract void draw();
    //}
    //public class Circle : Shapes
    //{
    //    public override void draw() // override keyword is neccessary //overriding
    //    {
    //        Console.WriteLine("Circle Is Drawn");
    //    }
    //}
    public class Shapes { 
        public void draw()
        {
            Console.WriteLine("Base Hello World");
        }
    }
    public class Circle
    {
        public int draw() // overloading
        {
            Console.WriteLine("Derived Hello World");
            return 0;
        }
    }
}