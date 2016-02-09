//using System;


//class RadiansToDegrees
//{
//    static void Main()
//    {

//        var number = double.Parse(Console.ReadLine());

//        var formula = number * (180.0 / Math.PI);

//        Console.WriteLine(Math.Round(formula, 2));
//    }
//}

////////////////////////////////////////////////////////////////////////////////////////////////


using System;


class RadiansToDegrees
{
    static double RadToDegConv(double number)
    {
        var formula = number * (180.0 / Math.PI);
        var result = Math.Round(formula, 2);
        return result;
    }

    static void Main()
    {

        var number = double.Parse(Console.ReadLine());
        var result = RadToDegConv(number);

        Console.WriteLine(result);
        

      
    }
}