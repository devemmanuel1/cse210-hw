/*
I showed extra creativity by adding a new feature that keeps track of the total time spend in each activity and displays
        that number at the end of each activity.
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create BreathingActivity object
        BreathingActivity breathingActivity = new BreathingActivity();

        // Create ReflectingActivity object
        ReflectingActivity reflectingActivity = new ReflectingActivity();

        // Create ListingActivity object;
        ListingActivity listingActivity = new ListingActivity();
        
        // Menu loop
        string userInput = "";
        while (userInput != "4") {
            // Display menu options and get user's selection
            DisplayMenu();
            userInput = Console.ReadLine();

            if (userInput == "1") // Start breathing activity
            {
                breathingActivity.Run();
            }
            else if (userInput == "2") // Start reflecting activity
            {
                reflectingActivity.Run();
            }
            else if (userInput == "3") // Start listing activity
            {
                listingActivity.Run();
            }

        }
    }

    public static void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        Console.WriteLine("Select a choice from the menu");
    }
}