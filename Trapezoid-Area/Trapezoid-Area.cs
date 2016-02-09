//using System;

//class TrapezoidArea
//{
//    static void Main()
//    {
//        var b1 = double.Parse(Console.ReadLine());
//        var b2 = double.Parse(Console.ReadLine());
//        var h = double.Parse(Console.ReadLine());
//        var area = (b1 + b2) * h / 2;
//        Console.WriteLine("Trapezoid area = {0}", area);
//    }
//}

////////////////////////////////////////////////////////////////////////////////////////////////

using System;

class TrapezoidArea
{
    static double TrapezoidAreaCalc(double b1, double b2, double h)
    {
        var area = (b1 + b2) * h / 2;
        return area;
    }

    static void Main()
    {
        var b1 = double.Parse(Console.ReadLine());
        var b2 = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());
      
        Console.WriteLine("Trapezoid area = {0}", TrapezoidAreaCalc(b1, b2, h));
    }
}

