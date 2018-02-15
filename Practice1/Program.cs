using System;

namespace Treehouse.PracticeSession
{
    class Program
    {
        static void Main()
        {
            // TODO Declare and assign a "thing" string variable.
            // Example: "movie", "book", "color", etc.
            string thing = "book";

            // TODO Prompt the user with the text "What is your name?" 
            // and assign their value to a "name" string variable.
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            // TODO Prompt the user with the text 
            // "What is your favorite <thing>?" 
            // and assign their value to a "favoriteThing" string variable.
            Console.WriteLine(value: "What is your favorite " + thing + " ?");
            string favoriteThing = Console.ReadLine();

            // TODO Write the user's name and favorite thing to the console.
            // Example: "My name is James and my favorite movie is Toy Story."
            Console.WriteLine("My name is " + name + " and my favorite " + thing + " is " + favoriteThing + ".");
            Console.WriteLine("Press any key to close");
            Console.ReadKey();


            // TODO Declare a boolean variable named "keepGoing"
            // and assign it a value of "true". Use this variable to 
            // know when to exit the while loop.

            // TODO Define a while loop.
            // Keep looping as long as the variable "keepGoing" has a value of "true".

                // TODO Prompt the user with the text "Enter a number:" 
                // and assign their value to an "entry" string variable.

                // TODO If the user entered the text "quit"...

                    // TODO Exit the program.

                // TODO Else the user didn't enter the text "quit"...

                    // TODO Parse the user's entry to an integer

                    // TODO Square the user's provided number 
                    // (i.e. multiply the number by itself).

                    // TODO Output the result.
                    // Example: "The square of 2 is 4." or 
                    // "2 multiplied by itself is equal to 4."

            // TODO Output the text "Goodbye!" after exiting the loop.

        }
    }
}
