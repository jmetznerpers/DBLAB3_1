using System;

namespace lab_3_1
{
    class Program
    {
        static bool KeepGoing()
        {
            // Version 0.04. (Agile Programming)
            while (true)
            {
                // Print out message asking if user wants to continue
                Console.WriteLine("Would you like to go again? (y/n)");
                // Ask the user for their input
                string response = Console.ReadLine();
                response = response.ToLower();
                // Check if they typed "y". If so, return true.
                // Otherwise return false.   YES   yes
                if (response == "y" || response == "yes")
                {
                    return true;
                }
                else if (response == "n" || response == "no")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter y or n");
                }
            }
        }

        static void Main(string[] args)
        {
            do
            {
                string[] students = { "George", "Susan", "Oswald", "Manuel", "Napolean" };
                string[] food = { "Cherries", "Bangers and mash", "Penguin Meat", "Menudo", "Creme Brulee" };
                string[] title = { "The first President of the United States!", "Champion of Temperance", "Lord of the Sewers", "First President of Mexico", "Emperor" };

                Console.WriteLine("Welcome to our DevBuild class.  Which student would you like to know more about?");
                for (int x = 0; x < students.Length; x++) //x < food.Length; x < title.Length;
                {
                    Console.WriteLine($"{x + 0} {students[x]}"); //, { food[x]}, { title[x]}
                }
                Console.WriteLine("Please enter 0-4");
                string choice = Console.ReadLine();
                int response = int.Parse(choice);
                if (response == 0)
                {
                    Console.WriteLine($"Would you like to know {students[0]}'s favorite food or his title? ");
                    string choice2 = Console.ReadLine();
                    if (choice2 == "food")
                    {
                        Console.WriteLine($"{students[0]}'s favorite food is {food[0]}!");
                    }
                    else if (choice2 == "title")
                    {
                        Console.WriteLine($"{students[0]} was best known as {title[0]}!");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid choice!");
                    }
                }
                else if (response == 1)
                {
                    Console.WriteLine($"Would you like to know {students[1]}'s favorite food or his title? ");
                    string choice2 = Console.ReadLine();
                    if (choice2 == "food")
                    {
                        Console.WriteLine($"{students[1]}'s favorite food is {food[1]}!");
                    }
                    else if (choice2 == "title")
                    {
                        Console.WriteLine($"{students[1]} was best known as {title[1]}!");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid choice!");
                    }
                }
                else if (response == 2)
                {
                    Console.WriteLine($"Would you like to know {students[2]}'s favorite food or his title? ");
                    string choice2 = Console.ReadLine();
                    if (choice2 == "food")
                    {
                        Console.WriteLine($"{students[2]}'s favorite food is {food[2]}!");
                    }
                    else if (choice2 == "title")
                    {
                        Console.WriteLine($"{students[2]} was best known as {title[2]}!");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid choice!");
                    }
                }
                else if (response == 3)
                {
                    Console.WriteLine($"Would you like to know {students[3]}'s favorite food or his title? ");
                    string choice2 = Console.ReadLine();
                    if (choice2 == "food")
                    {
                        Console.WriteLine($"{students[3]}'s favorite food is {food[3]}!");
                    }
                    else if (choice2 == "title")
                    {
                        Console.WriteLine($"{students[3]} was best known as {title[3]}!");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid choice!");
                    }
                }
                else if (response == 4)
                {
                    
                    
                        Console.WriteLine($"Would you like to know {students[4]}'s favorite food or his title? ");
                        string choice2 = Console.ReadLine();
                   // while (choice2 != "food" || choice2 != "title")
                   // {
                        Console.WriteLine("Please enter food or title!");
 //                       string choice2 = Console.ReadLine();

                        if (choice2 == "food")
                        {
                            Console.WriteLine($"{students[4]}'s favorite food is {food[4]}!");
                        }
                        else if (choice2 == "title")
                        {
                            Console.WriteLine($"{students[4]} was best known as {title[4]}!");
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid choice!");
                        }
                   // }
                    
                }
                else
                {
                    Console.WriteLine("Please enter a number 0 through 4");
                }




            }

            while (KeepGoing());
        }
    }
}
