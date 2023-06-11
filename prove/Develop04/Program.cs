using System;
using System.Collections.Generic;
using MindfulnessApp;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Welcome to the Mindfulness App!");

        while (true)
        {
            Console.WriteLine("\nPlease choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.WriteLine("");
            Console.Write("Select one of the available options: ");
            string input = Console.ReadLine();
            Activity _newActivity = null;



            if (input == "1")
            {
                _newActivity = new BreathingActivity();
                Console.Clear();
                _newActivity.StartActivity();
                _newActivity.RunActivity();
                _newActivity.EndActivity();
            }

            else if (input == "2")
            {
                _newActivity = new ReflectionActivity();
                Console.Clear();
                _newActivity.StartActivity();
                _newActivity.RunActivity();
                _newActivity.EndActivity();
            }

            else if (input == "3")
            {
                _newActivity = new ListingActivity();
                Console.Clear();
                _newActivity.StartActivity();
                _newActivity.RunActivity();
                _newActivity.EndActivity();
            }

            else if (input == "4")
            {
                Console.WriteLine("");
                Console.WriteLine("Thank you for using the Mindfulness App!");
                Console.WriteLine("");
                Environment.Exit(0);
                break;
            }

            else
            {
                Console.WriteLine("Invalid input. Please input one of the available options.");
            }
        }
    }
}