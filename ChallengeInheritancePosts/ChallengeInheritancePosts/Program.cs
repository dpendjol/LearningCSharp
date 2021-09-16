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
        }
    }
}
