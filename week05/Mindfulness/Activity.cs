public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int SetDuration(int dur)
    {
        return _duration = dur;
    }
    public void DisplayStartingMessage()
    {
         Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Thread.Sleep(2000);
        Console.WriteLine(_description);
        Thread.Sleep(2000);
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have done a good job");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed the {_name} Activity for {_duration} seconds.");
        ShowSpinner(3);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

    

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);
    int i = 0;
        while (DateTime.Now < endTime)
        {
           string s = animation[i];
           Console.Write(s);
           Thread.Sleep(1000);
           Console.Write("\b \b");
           i++;
        }
        if(i >= animation.Count)
        {
            i = 0;
        }
    }
    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public abstract void Run();
}