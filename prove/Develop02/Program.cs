
//I added extra creativity and exceeding requirements by improving the process for both loading from and saving to a file by automatically appending the filetype “.txt” to the end of the filename so that the user does not need to include the filetype when asked to enter the name of the file and also when a new entry is added to the journal, I included the day of the week that the entry was created on as part of the information saved to the journal.

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Journal class instance and PromptGenerator class instance
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        // Populate the prompts and store in the promptGenerator instance
        PopulatePrompts(promptGenerator);

        // Introduction
        Console.WriteLine();
        Console.WriteLine("Welcome to your Journal!!!");

        // Menu loop
        int userChoice = 0;
        while (userChoice != 5)
        {
            ShowMenu();

            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1) // Write a new entry
            {
                WriteNewEntry(journal, promptGenerator);
            }
            else if (userChoice == 2) // Display the journal
            {
                journal.DisplayAll();
            }
            else if (userChoice == 3) // Load the journal from a file
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.LoadFromFile($"{fileName}.txt");
            }
            else if (userChoice == 4) // Save the journal to a file
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.SaveToFile($"{fileName}.txt");
            }
            else if (userChoice == 5) // Quit the promgram
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
    public static void ShowMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }
    public static void PopulatePrompts(PromptGenerator promptGenerator)
    {
        List<string> prompts = [
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        ];
        promptGenerator._prompts = prompts;
    }
    public static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {
        // Get a random prompt
        string randomPrompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.Write("> ");

        // Get the users entry
        string usersEntry = Console.ReadLine();

        // Get the date and day of week for the entry
        DateTime currentDateTime = DateTime.Now;
        DayOfWeek currentDayofWeek = currentDateTime.DayOfWeek;

        // Create new entry
        Entry entry = new Entry();
        entry._date = currentDateTime.ToShortDateString();
        entry._dayOfWeek = currentDayofWeek.ToString();
        entry._promptText = randomPrompt;
        entry._entryText = usersEntry;

        // Save new entry to the journal
        journal.AddEntry(entry);
    }
}