using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignmentPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // part 1
            // Create a one-Dimentional array of strings
            string[] wordstart =
            {
                "Welcome to The ",
                "I'm Principal, ",
                "Our goal is to provide our students with a ",

            };
            string[] wordend =
            {
                " Academy.",
                ".",
                " learning experience."
            };
            List<string> responses = new List<string>();
            // Ask user to input text
            Console.WriteLine("Please enter a noun:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Pleae enter the name of someone infamous:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter an adjective");
            responses.Add(Console.ReadLine());
            // Loop to add user input to string.
            for (int i = 0; i < wordstart.Length; i++)
            {
                wordstart[i] += responses[i];
                Console.WriteLine(wordstart[i] + wordend[i]);
            }
            Console.ReadLine();
            Console.WriteLine("The strings we used:");
            for (int i = 0;i < wordstart.Length; i++)
            {
                Console.WriteLine(wordstart[i] + wordend[i]);
            
                //part 2
                //Create an infinate Loop - added "i--"
                //Fix - commented "i--"
                // i--;
            }
            Console.ReadLine();

            // Part 3
            Console.WriteLine("Is that a ghost?!");
            StringBuilder boo = new StringBuilder();
            boo.Append("B");
            // Loop to continue while < 
            while (boo.Length < 10) 
            {
                boo.Append("o");
            }
            boo.Append("!");
            Console.ReadLine();
            Console.WriteLine(boo);
            Console.ReadLine();
            StringBuilder ahh = new StringBuilder();
            ahh.Append("A");
            // loop to continue while <=
            while (ahh.Length <= 10) 
            {
                ahh.Append("h");
            }
            ahh.Append("!");
            Console.WriteLine(ahh);
            Console.ReadLine();

            // Part 4
            // List of strings with Unique items
            List<string> teams = new List<string>()
            {
                "Bucks", "Raptors", "Celtics", "Heat", "Pacers", "76ers", "Nets", "Magic",
                "Wizards", "Hornets", "Bulls", "Knicks", "Pistons", "Hawks", "Cavaliers"
            };
            Console.WriteLine("NBA Eastern Conference Standins");
            // Input team name to search in list
            Console.WriteLine("Enter team name:");
            int standing = 0;
            bool isValid = false;
            int index = 0;
            // Loop to search list and displays matchign text.
            while (!isValid) 
            {
                int i2 = 0;
                string teamrequest = Console.ReadLine();
                foreach (string team in teams)
                {
                    if (teamrequest == team) 
                    {
                        standing = i2 + 1;
                        index = i2;
                    }
                    i2++;
                }
                // code to tell if input is not in list.
                if (standing == 0) 
                {
                    Console.WriteLine("That is not a valid team name. Enter again:");
                }
                // code to stop loop when a match is found
                else
                {
                    isValid = true;
                }
            }
            Console.WriteLine("Processing.... Index is: " + index + ". So...");
            Console.WriteLine("Standing is: " + standing);
            Console.ReadLine() ;

            // Part 5
            // Create list of strings that has multiple identical stringsin list. 
            List<string> tables = new List<string>() { "Reserved", "Vacant", "Taken", "Vacant", "Vacant", "Reserved", "Taken" };
            Console.WriteLine("Welcome to Swell Taco! \nDue to COVID-19 we have a computerized check-in. \nIf you have a reservation type " +
                "\"Reserved\".\nIf you are joining a party that is already here type \"Taken\".\nOtherwise type \"Vacant\".");
            // ask user to select text to search in the list
            Console.WriteLine("Enter selection:");
            string selection = Console.ReadLine();
            while (!(selection == "Vacant" || selection == "Rexerved" || selection == "Taken"))
            {
                // error text for incorrect input
                Console.WriteLine("Please enter one of the 3 choices:");
                selection = Console.ReadLine();
            }
            Console.WriteLine("The tables that match your selection are numbered:");
            // search and display matching text in the array
            for (int i3 = 0; i3 < tables.Count; i3++)
            {
                if (selection == tables[i3]) 
                {
                    Console.WriteLine(i3);
                }
            }
            Console.ReadLine();

            // part 6
            // create a list that has at least 2 identical strings in list
            List<string> names = new List<string>() { "Bob", "Jim", "Tiffany", "Bob", "Kat", "Mary", "Mary" };
            List<string> repeatCheck = new List<string>();
            Console.WriteLine("class Roster:");
            // foreach loop to evaluate each item in the list, and display a message showing the string and whether or not it has already appeard in the list.
            foreach (string name in names) 
            {
                Console.WriteLine(name);
                if (repeatCheck.Contains(name))
                {
                    Console.WriteLine("This name has been repeated. \nuse last name initial when referring to this student.");
                }
                else
                {
                    Console.WriteLine("this name has not been repeated.");
                }
                repeatCheck.Add(name);
            }
            Console.ReadLine();
        }
    }
}
