using System;

class SquareOfStars
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        string stars = new string('*', N);
        string empty = new string(' ', N - 2);
       
        Console.WriteLine(stars);
        for(int i = 0; i < N - 2; i++)
        {
            Console.WriteLine("*" + empty + "*");
        }
        Console.WriteLine(stars);

           
        }
    }
