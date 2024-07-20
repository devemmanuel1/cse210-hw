using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Actually Train a Dragon", "The Dragon Man", 345);
        Comment comment1 = new Comment("DragonLover87", "If a dragon were truly trainable that would be so cool!");
        Comment comment2 = new Comment("user44", "I don't believe in dragons.");
        Comment comment3 = new Comment("Rod Hairs", "Great video. Very information. Where can I buy one of these dragons for myself?");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        videos.Add(video1);

        Video video2 = new Video("2015 Nissan Sentra Oil Change", "DIY Car", 239);
        Comment comment4 = new Comment("MyNissan", "Does this work for any Nissan model?");
        Comment comment5 = new Comment("Todd Bywell", "Great! Needed this.");
        Comment comment6 = new Comment("Phil Michaels", "Made it look easy you did.");
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        videos.Add(video2);

        Video video3 = new Video("A Day in the Life: Working for Apple", "Fred Hiwalk", 587);
        Comment comment7 = new Comment("John Curtus", "That looks so cool! I wish that I could work for Apple as well. One I will work for them for sure!");
        Comment comment8 = new Comment("user99993", "Working for Microsoft is way better than working for Apple.");
        Comment comment9 = new Comment("Helt Uni", "Loved the video! Hope you make more like this one.");
        Comment comment10 = new Comment("Anonymous", "Are you sure Apple is okay with you posting this video??");
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);
        videos.Add(video3);

        Console.Clear();
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}