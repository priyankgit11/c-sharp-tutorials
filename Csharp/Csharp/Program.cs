using System;
using System.Reflection;
using System.Threading.Channels;
//using ProjectA.TeamA;
//using ProjectA.TeamB;
//namespace ProjectA
//{
//    namespace TeamA
//    {
//        class ClassA
//        {
//            public static void Print()
//            {
//                Console.WriteLine("Team A Print Method");
//            }
//        }
//    }
//    namespace TeamB
//    {
//        class ClassA
//        {
//            public static void Print()
//            {
//                Console.WriteLine("Team B Print Method");
//            }
//        }
//    }
//}
class Program
{
    //enum ErrorCode : int
    //{
    //    None = 0,
    //    Unknown = 1,
    //    ConnectionLost = 100,
    //    OutlierReading = 200
    //}
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    //interface IPoint
    //{
    //    // Property signatures:
    //    int X { get; set; }

    //    int Y { get; set; }

    //    double Distance { get; }
    //}

    //class Point : IPoint
    //{
    //    // Constructor:
    //    public Point(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    // Property implementation:
    //    public int X { get; set; }

    //    public int Y { get; set; }

    //    // Property implementation
    //    public double Distance =>
    //       Math.Sqrt(X * X + Y * Y);
    //}
    //static void PrintPoint(IPoint p)
    //{
    //    Console.WriteLine("x={0}, y={1}", p.X, p.Y);
    //}
    static void Main(String[] args)
    {
        //int x = 12;
        //int? y = null; // Shorthand of Nullable<int> y = null;
        //Jagged Arrays(arrays of array having different size of array at each index)
        //int[][] arr = new int[2][];
        //arr[0] = new int[4];
        //arr[1] = new int[2];
        //Circle c1 = new Circle(4);
        //Console.WriteLine(c1.GetType());
        //Console.WriteLine(c1.GetType()==typeof(Circle));
        //Console.WriteLine(c1.GetType()==typeof(Shapes));
        //ErrorCode ec = ErrorCode.ConnectionLost | ErrorCode.Unknown | ErrorCode.OutlierReading;
        //ErrorCode ec=ErrorCode.None;
        //Console.WriteLine(((int)ec));
        //Season a = Season.Autumn;
        //Console.WriteLine($"Integral value of {a} is {(int)a}");
        //var b = (Season)1;
        //Console.WriteLine(b);
        //string str = "Hello World";
        //string ptr = str;
        //Console.WriteLine(ptr);
        //Console.WriteLine(str);
        //ptr = "Bye BYe World";
        //Console.WriteLine(ptr);
        //Console.WriteLine(str);
        //Callback handler = DelegateMethod;
        //handler("Hello World");
        //var pair = new Pair<int, string>(1, "two");
        //int i = pair.First;
        //string s = pair.Second;
        //Console.WriteLine(i);
        //Console.WriteLine(s);
        //IPoint p = new Point(2, 3);
        //Console.WriteLine("My Point: ");
        //PrintPoint(p);
    }
    //public delegate void Callback(string message);
    //public static void DelegateMethod(string message)
    //{
    //    Console.WriteLine(message);
    //}
    //public class Pair<TFirst, TSecond>
    //{
    //    public TFirst First { get; }
    //    public TSecond Second { get; }
    //    public Pair(TFirst first, TSecond second) =>
    //   (First, Second) = (first, second);
    //}
}

//class Shapes { }
//class Circle : Shapes
//{
//    public static float _PI = 3.14F;
//    public const int h = 12;
//    int _Radius;
//    static Circle()
//    {
//        Console.WriteLine("static Parametered Constructor called");
//    }
//    public Circle(int radius)
//    {
//        Console.WriteLine("Parameterised Constructor called");
//        this._Radius = radius;
//    }

//    public float CalculateArea()
//    {
//        return _PI * this._Radius * this._Radius;
//    }
//    public override string ToString() => $"{_PI} [{string.Join(", ", _Radius)}]";
//}
