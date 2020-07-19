using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
        string[] presidents = { "George Washington", "John Adams", "Thomas Jefferson" };
        Console.WriteLine("Enter a number that represents the index position of an array of Presidents of the US: ");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input>presidents.Length)
        {
            Console.WriteLine("You have chosen an index number that is outside the range of the array, choose a number between 0 and 2.");
            Console.ReadLine();
            Main();
        }
        Console.WriteLine("The President at index #" + input + " is " + presidents[input]+ ".");

        int[] intArray = { 42, 21, 84, 168 };
        Console.WriteLine("Enter a number that represents the index position of an array of integers: ");
        int input2 = Convert.ToInt32(Console.ReadLine());
        if (input2>intArray.Length)
        {
            Console.WriteLine("You have chosen an index number that is outside the range of the array, choose a number between 0 and 3.");
            Console.ReadLine();
            Main();
        }

        Console.WriteLine("The integer at index #" + input2 + " is " + intArray[input2] + ".");

        List<string> stringList = new List<string>() { "Charlie Blackmon", "Nolan Arenado", "Tony Wolters" };
        Console.WriteLine("Enter a number that represents the index position of a list of Colorado Rockies players: ");
        int input3 = Convert.ToInt32(Console.ReadLine());
        if (input3 > stringList.Count)
        {
            Console.WriteLine("You have chosen an index number that is outside the range of the array, choose a number between 0 and 2.");
            Console.ReadLine();
            Main();
        }
        Console.WriteLine("The player at index #" + input3 + " is " + stringList[input3] + ".");

        
        Console.ReadLine();
        }
    }

