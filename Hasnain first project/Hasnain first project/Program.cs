using System;

namespace Hasnain_first_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mad Libs Fill in the blank prompts
            Console.Write("Enter a holiday :"); string holiday = Console.ReadLine();
            Console.Write("Enter a noun : "); string noun1 = Console.ReadLine();
            Console.Write("Enter a place : "); string place = Console.ReadLine();
            Console.Write("Enter a person : "); string person = Console.ReadLine();
            Console.Write("Enter an adjective : "); string adjective1 = Console.ReadLine();
            Console.Write("Enter a plural body part : "); string bodypartPlural = Console.ReadLine();
            Console.Write("Enter a verb : "); string verb = Console.ReadLine();
            Console.Write("Enter an adjective : "); string adjective2 = Console.ReadLine();
            Console.Write("Enter a noun : "); string noun2 = Console.ReadLine();
            Console.Write("Enter a food : "); string food = Console.ReadLine();
            Console.Write("Enter a plural Noun : "); string pluralNoun = Console.ReadLine();
            
            //Adding an if statement to not allow ing words?
            
            //Mad Libs final product / showing the filled in spaces


            Console.WriteLine("Halloween Mad Libs ! ");

            Console.WriteLine( "I can't believe it's already " + 
                holiday + ". I can't wait to put on my " + noun1 + 
                " and visit every " + place + " in my neighborhood. This year, I am going to dress up as " 
                + person + " with " + adjective1 + " " + bodypartPlural + " Before I " + verb + " I make sure to grab my " 
                + adjective2 + " "
                + noun2 + " to hold all of my " + food +
                " Finally, all of my " + pluralNoun + " are ready to go!");

            Console.ReadLine();

        }
    }
}
