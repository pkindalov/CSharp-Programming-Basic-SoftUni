using System;

class USDtoBGN
{
    static void Main()
    {
        var dollars = double.Parse(Console.ReadLine());

        var convertToBGN = dollars * 1.79549;
        Console.WriteLine(Math.Round(convertToBGN, 2));
    }
}


