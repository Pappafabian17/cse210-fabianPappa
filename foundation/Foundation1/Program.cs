using System;

class Program
{
    static void Main(string[] args)
    {
        //the image is on the directory
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to use Classes in C#","Fabian",750);
        video1.AddComment(new Comment("josh","it's very helpful!"));
        video1.AddComment(new Comment("Carly","Can you explain better in the next video ?"));
        video1.AddComment(new Comment("Drake","It's awesome I love to play the guitar and you love to code"));
        video1.AddComment(new Comment("Sam","it's so difficult!"));

        Video video2 = new Video("How to use Classes in C# part - 2","Juan Carlos",630);
        video2.AddComment(new Comment("Nephi","this does not exist on my age!"));
        video2.AddComment(new Comment("James","How can i improve?"));
        video2.AddComment(new Comment("Jayen","I like it!"));
        video2.AddComment(new Comment("Samuel","sounds good! is very interesting!"));

        videos.Add(video1);
        videos.Add(video2);

        foreach(var video in videos)
        {
            Console.WriteLine($"Title:{video._title}");
            Console.WriteLine($"Author:{video._author}");
            Console.WriteLine($"Time:{video._length} seconds");
            Console.WriteLine($"Comments amount:{video.GetComments()}");

            Console.WriteLine("Comments:");

            foreach(var comment in video.Comments)
            {
                Console.WriteLine($"{comment._user}: {comment._text}");
            }
            Console.WriteLine();
        }
    }
}