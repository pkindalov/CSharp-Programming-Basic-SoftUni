//using System;

//class InchesToCentimeters
//{
//    static void Main()
//    {
//        Console.Write("Inches = ");
//        var inches = double.Parse(Console.ReadLine());
//        var centimeters = inches * 2.54;
//        Console.Write("Centimeters = ");
//        Console.WriteLine(centimeters);
//    }
//}


using System;

class InchesToCentimeters
{
    static double InchesConvToCm(double inches)
    {
        var centimeters = inches * 2.54;
        return centimeters;
    }
    static void Main()
    {
        Console.Write("Inches = ");
        var inches = double.Parse(Console.ReadLine());
       
        Console.Write("Centimeters = ");
        Console.WriteLine(InchesConvToCm(inches));
    }
}