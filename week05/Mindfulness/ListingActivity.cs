using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who have you helped this week?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity()
        : base("Listing",
        "This activity will help you reflect on the good things in your life.")
    {
    }

    public override void Run()
    {
        DisplayStartingMessage();

        GetRandomPrompt();
        ShowCountDown(5);

        Console.WriteLine("\nStart listing items:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");

        DisplayEndingMessage();
    }
   public string GetRandomPrompt()
{
    int number = _random.Next(0, _prompts.Count);
    return _prompts[number];
}
    public void GetListFromUser(string prompt)
    {
        _prompts.Add(prompt);
    }
}