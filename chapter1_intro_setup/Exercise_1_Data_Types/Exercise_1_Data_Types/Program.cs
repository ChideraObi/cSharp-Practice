using System;

namespace Exercise_1_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //Have the program greet user by name
            Console.WriteLine("What is your name!");

            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);

            //Calculate the area of a rectangle
            Console.WriteLine("What is the length of the rectangle?");
            string length = Console.ReadLine();

            Console.WriteLine("What is the width of the rectangle?");
            string width = Console.ReadLine();

            Console.WriteLine("The area of your rectangle is " + (int.Parse(length) * int.Parse(width)));

            //miles-per-gallon
            Console.WriteLine("How many miles have you driven, " + name + "?");
            string miles = Console.ReadLine();

            Console.WriteLine("Cool. How many gallons of gas have you used so far?");
            string gas = Console.ReadLine();

            int mpg = int.Parse(miles) * int.Parse(gas);

            Console.WriteLine("Awesome. Sounds like you've used " + mpg + "miles-per-gallon so far.");

            string wonderland = "Alice was beginning to get" +
                " very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped " +
                "into the book her sister was reading, but it had no pictures or" +
                " conversations in it, 'and what is the use of a book,' thought Alice" +
                " 'without pictures or conversation?'";

            Console.WriteLine("Name a term found in the first sentence in 'Alice's Adventures in Wonderland'");

            string term = Console.ReadLine().ToLower();

            wonderland = wonderland.ToLower();

            int search = wonderland.IndexOf(term);

            Console.WriteLine(term + " was found at " + search);

            int size = term.Length;

            string NewWonderland = wonderland.Remove(search, size);

            Console.WriteLine(NewWonderland);

        }
    }
}
