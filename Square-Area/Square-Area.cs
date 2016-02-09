//using System;

//class SimpleCalculationsExercise
//{
//    static void Main()
//    {
//        Console.Write("Enter side a of square = ");
//        var a = double.Parse(Console.ReadLine());
//        var area = a * a;
//        Console.Write("Square Area = ");
//        Console.WriteLine(area);


//    }
//}

////////////////////////////////////////////////////////////////////////////////////////////////



using System;

class SimpleCalculationsExercise
{
    static double SquareAreaCalc(double a)
    {
        var area = a * a;
        return area;
    }

    static void Main()
    {
        Console.Write("Enter side a of square = ");
        var a = double.Parse(Console.ReadLine());
       
        Console.Write("Square area = ");
        Console.WriteLine(SquareAreaCalc(a));


    }
}