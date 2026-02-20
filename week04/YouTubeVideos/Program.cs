using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Learn C#", "CodeMaster", 600);
        video1.AddComment(new Comment("Alice", "Great explanation!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks."));
        video1.AddComment(new Comment("Charlie", "I finally understand classes!"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("OOP in 10 Minutes", "TechGuru", 480);
        video2.AddComment(new Comment("David", "Clear and simple."));
        video2.AddComment(new Comment("Emma", "Loved the examples."));
        video2.AddComment(new Comment("Frank", "More videos like this please."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Understanding Abstraction", "DevChannel", 720);
        video3.AddComment(new Comment("Grace", "This helped me with my homework."));
        video3.AddComment(new Comment("Henry", "Best explanation I've seen."));
        video3.AddComment(new Comment("Isabella", "Can you explain encapsulation next?"));
        videos.Add(video3);

        // Display Information
        foreach (Video video in videos)
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length (seconds): {video.GetLength()}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}