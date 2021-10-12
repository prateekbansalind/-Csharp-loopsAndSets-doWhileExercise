using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercise program to demonstrate usage of do while loop.

            // If this user enters "Prateek" or either "Shriram," it will return Mr. firstName Bansal, whereas if the first name is not either "Prateek" or "Shriram," it will say Hello, firstName. Also, after the first entry, the program will ask you to make another entry. This program has the usage of an if-else loop and a do-while loop. 

            string decisionVariable = "";

            do
            {
                Console.Write("What is your name: ");
                string firstName = Console.ReadLine();

                if (firstName.ToLower() == "prateek" || firstName.ToLower() == "shriram")
                {
                    Console.WriteLine($"Hello Mr. {firstName} Bansal");
                }
                else
                {
                    Console.WriteLine($"Hello, {firstName}");
                }

                Console.Write("Do you want to make another entry press enter, if not then type 'exit': ");
                decisionVariable = Console.ReadLine();

            } while (decisionVariable.ToLower() != "exit");


            Console.ReadLine();
        }
    }
}