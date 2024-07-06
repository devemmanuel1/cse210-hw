public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = []; 

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts = [
            "What are some achievements you are proud of?",
            "What recent experiences have brought you joy?",
            "What skills or talents do you enjoy using?",
            "Who are the people who inspire you?",
            "What are some of your favorite memories from this year?"
        ];

        _totalDuration = 0;
    }

    public void Run()
    {
        // Show starting message
        DisplayStartingMessage();

        // Display random prompt
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("You may begin in  ");
        ShowCountDown(9);

        // Get list from user and display number of items from the list
        List<string> userList = GetListFromUser();
        _count = userList.Count;
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();

        // Increment total duration
        _totalDuration += _duration;

        // Show ending message
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);

        return _prompts[randomIndex];
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = [];

        // Loop until the duration is reached
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            userList.Add(Console.ReadLine());
        }

        return userList;
    }   
}