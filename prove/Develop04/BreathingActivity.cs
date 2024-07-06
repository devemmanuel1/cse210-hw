public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "The Breathing Activity";
        _description = "This activity will help you relax by guiding you through slow breathing. Clear your mind and concentrate on your breath.";
        _totalDuration = 0;
    }

    public void Run()
    {
        // Show starting message
        DisplayStartingMessage();

        // Loop until duration is reached
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.Write("Now breathe out... ");
            ShowCountDown(6);
            Console.WriteLine();
        }

        // Increment total duration
        _totalDuration += _duration;

        // Show ending message
        DisplayEndingMessage();
    }
}