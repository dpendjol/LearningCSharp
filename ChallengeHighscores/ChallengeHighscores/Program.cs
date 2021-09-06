using System;
/* 
Create an application with a score, highscore and a highscorePlayer.
Create a method which has two parameters, one for the score and one for the playerName.
When ever that method is called, it should be checked if the score of the player is higher than 
  the highscore, if so, "New highscore is + " score" and in another line 
  "New highscore holder is " + playerName - should be written onto the console,
  if not "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.
Consider which variables are required globally and which ones locally.
*/
namespace ChallengeHighscores
{
    class Program
    {
        static int highScore;
        static string highScoreHolder;
        static void Main(string[] args)
        {
            Console.WriteLine("HighScore");
            Console.WriteLine("---------");
            isNewHighScore(25, "Henk");
            isNewHighScore(10, "Piet");
            isNewHighScore(40, "Kees");
        }

        static bool isNewHighScore(int score, string playerName)
        {
            if (score > highScore)
            {
                highScore = score;
                highScoreHolder = playerName;
                Console.WriteLine($"New highscore is {highScore}");
                Console.WriteLine($"New highscore holder is {playerName}");
                return true;
            } else
            {
                Console.WriteLine($"The old highscore of {highScore} could not be broken and is still held by {highScoreHolder}");
                return false;
            }
        } 
    }
}
