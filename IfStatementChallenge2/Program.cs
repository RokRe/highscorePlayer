using System;

namespace IfStatementChallenge2
{
    internal class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "Rok";
        static int score;
        static string playerName;
        static string scoreLevel;

        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Current highscore holder is {0} with {1} points", highscorePlayer, highscore);
                Game();
                Console.ReadKey();
               
            }
           
            
        }
        public static void Game()
        {
            Console.WriteLine("\nNew game\nEnter your name:");
            playerName= Console.ReadLine();
            Console.WriteLine("What was your game score?");
            if (int.TryParse(Console.ReadLine(), out score)) {

                if (score > highscore)
                {
                    highscore = score;
                    highscorePlayer = playerName;
                    scoreLevel = score < 300 ? "bad" : (score < 1000 && score >= 300) ? "good" : "godlike";
                    Console.WriteLine("New highscore holder is {0} \nHighscore is now {1} points \nYour score is {2}\n", playerName, score, scoreLevel);
                }
                else
                {
                    scoreLevel = score < 300 ? "bad" : (score < 1000 && score >= 300) ? "good" : "godlike";
                    Console.WriteLine("The old highscore of {0} made by {1} could not be broken \nYour score is {2}\n", highscore, highscorePlayer, scoreLevel);
                }
                Console.WriteLine("Press enter to start new game");
            }
            else Console.WriteLine("wrong value, press any key to try a new game");
        }
    }
}
