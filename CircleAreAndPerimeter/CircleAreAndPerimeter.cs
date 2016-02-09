//using System;

//class CircleAreAndPerimeter
//{
//    static void Main()
//    {
//        var r = double.Parse(Console.ReadLine());
//        var area = Math.PI * r * r;
//        var perimeter = 2 * Math.PI * r;

//        Console.WriteLine("Area = {0}", area);
//        Console.WriteLine("Perimeter = {0}", perimeter);


//    }
//}

////////////////////////////////////////////////////////////////////////////////////////////////

//using System;

//class CircleAreAndPerimeter
//{
//    static void circleAreaAndPerim(double r)
//    {
//        var area = Math.PI * r * r;
//        var perimeter = 2 * Math.PI * r;
//        Console.WriteLine("Area = {0}", area);
//        Console.WriteLine("Perimeter = {0}", perimeter);

//    }

//    static void Main()
//    {
//        var r = double.Parse(Console.ReadLine());

//        circleAreaAndPerim(r);


//    }
//}

////////////////////////////////////////////////////////////////////////////////////////////////


using System;

class CircleAreAndPerimeter
{
    static double areaCalculate(double r)
    {
        var area = Math.PI * r * r;
        return area;
    }

    static double perimeterCalculate(double r)
    {
        var perimeter = 2 * Math.PI * r;
        return perimeter;
    }

    static void Main()
    {
        var r = double.Parse(Console.ReadLine());
       
        Console.WriteLine("Area = {0}", areaCalculate(r));
        Console.WriteLine("Perimeter = {0}", perimeterCalculate(r));


    }
}