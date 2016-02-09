//using System;

//class Greeting
//{
//    static void Main()
//    {
//        //Console.Write("Enter your name: ");
//        var name = Console.ReadLine();
//        Console.WriteLine("Hello, {0}!", name);

//    }
//}

////////////////////////////////////////////////////////////////////////////////////////////////

using System;

class Greeting
{
    static void greeting(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        //Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        greeting(name);

    }
}