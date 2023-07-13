using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Tie a Tie", "The Tie Guy", 185);
        video1.AddComment("Commenter 1", "Excellent! Just what I needed");
        video1.AddComment("Commenter 2", "No more clip-on ties for me!");
        video1.AddComment("Commenter 3", "Has it always been this easy???");
        videos.Add(video1);

        Video video2 = new Video("How to Draw a Horse", "Your Local Poor Artist", 120);
        video2.AddComment("Commenter 1", "A bit of a short video, but it's fairly good, I guess.");
        video2.AddComment("Commenter 2", "Why is this video so short? This didn't help at all...");
        videos.Add(video2);

        Video video3 = new Video("Garfield Video Essay", "Garfellow", 3627);
        video3.AddComment("Commenter 1", "Why is this video over an hour long when it only goes over a SINGLE comic strip?");
        video3.AddComment("Commenter 2", "Huh...");
        video3.AddComment("Commenter 3", "Haha what a funny cat");
        video3.AddComment("Commenter 4", "Me, when it's my turn to pick the movie for movie night.");
        videos.Add(video3);


        foreach (Video video in videos)
        {
            Console.WriteLine("");
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine();
            Console.WriteLine("Comments:");


            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("- " + comment._name + ": " + comment._text);
            }


            Console.WriteLine();
            Console.WriteLine("_______________________");
            Console.WriteLine();
        }
    }
}