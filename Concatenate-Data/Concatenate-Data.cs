//using System;

//class ConcatenateData
//{
//    static void Main()
//    {
//        var firstname = Console.ReadLine();
//        var lastname = Console.ReadLine();
//        var age = int.Parse(Console.ReadLine());
//        var town = Console.ReadLine();

//        Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstname, lastname, age, town);

//    }
//}

////////////////////////////////////////////////////////////////////////////////////////////////


using System;

class ConcatenateData
{
    static string concatenateStrs(string firstname, string lastname, string age, string town)
    {
      

        var result = firstname + " " + lastname + " " + age + " " + town;
        return result;
    }

    static void Main()
    {
        var firstname = Console.ReadLine();
        var lastname = Console.ReadLine();
        var age = Console.ReadLine();
        var town = Console.ReadLine();

        var result = concatenateStrs(firstname, lastname, age, town);
        Console.WriteLine(result);

        //Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstname, lastname, age, town);

    }
}