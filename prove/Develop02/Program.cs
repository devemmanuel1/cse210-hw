
//I added extra creativity and exceeding requirements by improving the process for both loading from and saving to a file by automatically appending the filetype “.txt” to the end of the filename so that the user does not need to include the filetype when asked to enter the name of the file and also when a new entry is added to the journal, I included the day of the week that the entry was created on as part of the information saved to the journal.

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        PopulatePrompts(promptGenerator);

        Console.WriteLine();
        Console.WriteLine("Welcome to your Journal!!!");

        // Menu loop
        int userChoice = 0;
        while (userChoice != 5)
        {
            ShowMenu();

            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1) 
            
            {
                WriteNewEntry(journal, promptGenerator);
            }
            else if (userChoice == 2) 
            {
                journal.DisplayAll();
            }
            else if (userChoice == 3) 
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.LoadFromFile($"{fileName}.txt");
            }
            else if (userChoice == 4) 
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                journal.SaveToFile($"{fileName}.txt");
            }
            else if (userChoice == 5)
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
            "How did I see the hand of our Heavenly Father in my life today?",
            "Who was the most interesting person I interacted with today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was the best part of my day?",
        ];
        promptGenerator._prompts = prompts;
    }
    public static void WriteNewEntry(Journal journal, PromptGenerator promptGenerator)
    {

        string randomPrompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine($"Prompt: {randomPrompt}");
        Console.Write("> ");


        string usersEntry = Console.ReadLine();

        DateTime currentDateTime = DateTime.Now;
        DayOfWeek currentdayofWeek = currentDateTime.DayOfWeek;

        Entry entry = new Entry();
        entry._date = currentDateTime.ToShortDateString();
        entry._dayOfWeek = currentdayofWeek.ToString();
        entry._promptText = randomPrompt;
        entry._entryText = usersEntry;

        journal.AddEntry(entry);
    }
}