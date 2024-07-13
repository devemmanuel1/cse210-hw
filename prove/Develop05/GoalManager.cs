public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int userInput = 0;
        while (userInput != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine();

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());

            if (userInput == 1)
            {
                CreateGoal();
            }
            else if (userInput == 2)
            {
                ListGoalDetails();
            }
            else if (userInput == 3)
            {
                SaveGoals();
            }
            else if (userInput == 4)
            {
                LoadGoals();
            }
            else if (userInput == 5)
            {
                RecordEvent();
            }

        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetGoalName()}");
            i++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int userInput = int.Parse(Console.ReadLine());
        if (userInput == 1)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int goalPoints = int.Parse(Console.ReadLine());

            SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
            _goals.Add(simpleGoal);
        }
        else if (userInput == 2)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int goalPoints = int.Parse(Console.ReadLine());

            EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
            _goals.Add(eternalGoal);
        }
        else if (userInput == 3)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int goalPoints = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int goalTarget = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int goalBonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int userInput = int.Parse(Console.ReadLine());
        
        int earnedPoints = _goals.ElementAt(userInput - 1).RecordEvent();
        _score += earnedPoints;
        Console.WriteLine($"Congratulation! You have earned {earnedPoints} points!");
        Console.WriteLine($"You now have {_score} points.");
        Console.WriteLine();
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine();
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();



        string[] lines = File.ReadAllLines(fileName);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] goalParts = lines[i].Split(":");
            string goalType = goalParts[0];
            string goalInfo = goalParts[1];


            if (goalType == "SimpleGoal")
            {
                string[] goalInfoParts = goalInfo.Split(",");
                string goalName = goalInfoParts[0];
                string goalDescription = goalInfoParts[1];
                int goalPoints = int.Parse(goalInfoParts[2]);
                string goalComplete = goalInfoParts[3];

                SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);

                if (goalComplete == "True") 
                {
                    simpleGoal.SetIsComplete(true);
                }

                _goals.Add(simpleGoal);
            }
            else if (goalType == "EternalGoal")
            {
                string[] goalInfoParts = goalInfo.Split(",");
                string goalName = goalInfoParts[0];
                string goalDescription = goalInfoParts[1];
                int goalPoints = int.Parse(goalInfoParts[2]);

                EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);

                _goals.Add(eternalGoal);
            }
            else if (goalType == "ChecklistGoal")
            {
                string[] goalInfoParts = goalInfo.Split(",");
                string goalName = goalInfoParts[0];
                string goalDescription = goalInfoParts[1];
                int goalPoints = int.Parse(goalInfoParts[2]);
                int bonusPoints = int.Parse(goalInfoParts[3]);
                int goalTarget = int.Parse(goalInfoParts[4]);
                int goalAmountComplete = int.Parse(goalInfoParts[5]);

                ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, bonusPoints);

                checklistGoal.SetAmountCompleted(goalAmountComplete);

                _goals.Add(checklistGoal);
            }
        }
        Console.WriteLine();
    }
}