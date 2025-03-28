using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Crear objetos Video y agregar comentarios
        Video video1 = new Video("Video 1", "John", 200);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "Nice content."));
        video1.AddComment(new Comment("Charlie", "Well done."));

        Video video2 = new Video("Video 2", "Jane", 150);
        video2.AddComment(new Comment("David", "Loved it!"));
        video2.AddComment(new Comment("Eve", "Could be improved."));

        Video video3 = new Video("Video 3", "Tom", 180);
        video3.AddComment(new Comment("Grace", "Excellent work."));
        video3.AddComment(new Comment("Hank", "Thanks for sharing!"));

        // Almacenar videos en una lista
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterar a través de los videos y mostrar la información
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}
