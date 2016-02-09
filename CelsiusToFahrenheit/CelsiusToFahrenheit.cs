//using System;

//class CelsiusToFahrenheit

//{
//    static void Main()
//    {

//        var celsius = double.Parse(Console.ReadLine());

//        var celciusToF = (celsius * 9) / 5 + 32;

//        Console.WriteLine(Math.Round(celciusToF, 2));
//    }
//}

////////////////////////////////////////////////////////////////////////////////////////////////

using System;

class CelsiusToFahrenheit
{
    static double CelsiusToFahrenheitConv(double celsius)
    {
        var celciusToF = (celsius * 9) / 5 + 32;
        return Math.Round(celciusToF, 2);
    }

    static void Main()
    {
        var celsius = double.Parse(Console.ReadLine());

        var result = CelsiusToFahrenheitConv(celsius);
        Console.WriteLine(result);
    }
}