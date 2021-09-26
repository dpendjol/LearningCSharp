using System;

namespace ChallengeInheritancePosts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program posts");

            Post post1 = new Post("This is my first post", true, "Henk de Vries");
            Console.WriteLine(post1.ToString());
            Post post2 = new Post("This is my second post", false, "Henk de Vries");
            Console.WriteLine(post2.ToString());
            post1.Update("This is my updated post", true);
            Console.WriteLine(post1.ToString());
            post1.Update("This is my updated post", false);
            Console.WriteLine(post1.ToString());

            Console.WriteLine("----------------------------------------------");

            ImagePost imagepost1 = new ImagePost("This is a image post", true, "Henk de Vries", "url://to.the.image");
            Console.WriteLine(imagepost1.ToString());
            ImagePost imagepost2 = new ImagePost("This is another image post", false, "Henk de Vries", "url://to.another.image");
            Console.WriteLine(imagepost2.ToString());
            imagepost2.Update("Another string", false);
            Console.WriteLine(imagepost2.ToString());

            Console.WriteLine("----------------------------------------------");

            VideoPost videopost1 = new VideoPost("This is a video post", true, "Henk de vries", "url://to.the.video", 20);
            Console.WriteLine(videopost1.ToString());

            videopost1.Play();
            Console.WriteLine(  "Press any key to stop playback");
            Console.ReadKey();
            videopost1.Stop();

            Console.ReadKey();
        }
    }
}
