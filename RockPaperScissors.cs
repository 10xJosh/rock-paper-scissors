using System;
using System.Threading;

namespace RockPaperScissorsGame
{
    public class RockPaperScissors
    {
        private string userResponse = "";
        private string cpuAnswer = "";
        private int playerScore = 0;
        private int cpuScore = 0;
        private string[] cpuOptions = { "rock", "paper", "scissors" };
        private bool killSwitch = true;

        public void Rock()
        {
            if (cpuAnswer == "scissors")
            {
                Score("player");
            }
            else if (cpuAnswer == "paper")
            {
                Score("cpu");
            }
            else
            {
                Draw();
            }
            runGame();
        }
        public void Paper()
        {
            if (cpuAnswer == "rock")
            {
                Score("player");
            }
            else if(cpuAnswer == "scissors")
            {
                Score("cpu");
            }
            else
            {
                Draw();
            }
            runGame();
        }
        public void Scissors()
        {
            if (cpuAnswer == "paper")
            {
                Score("player");
            }
            else if (cpuAnswer == "rock")
            {
                Score("cpu");
            }
            else
            {
                Draw(); 
            }
            runGame();
        }

        private void Score(string winner)
        {
            if (winner == "player")
            {
                Console.Clear();
                Console.WriteLine("*****\nYou win!!\n*****");
                Console.WriteLine("CPU HAD: {0}", cpuAnswer);
                playerScore++;
                Console.WriteLine("\n*****\nScore: Player: {0} CPU: {1}\n*****", playerScore, cpuScore);
                Confirmation();
            }
            if (winner == "cpu")
            {
                Console.Clear();
                Console.WriteLine("-----\nCPU wins!!\n-----");
                Console.WriteLine("CPU HAD: {0}", cpuAnswer);
                cpuScore++;
                Console.WriteLine("-----\nScore: Player: {0} CPU: {1}\n-----", playerScore, cpuScore);
                Confirmation();
            }
            runGame();
        }

        public void Confirmation()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public void Draw()
        {
            Console.Clear();
            Console.WriteLine("\n=====\nDRAW!\n=====\n");
            Console.WriteLine($"The CPU had {cpuAnswer}");
            Confirmation();
        }

        public void runGame()
        {
            Random random = new Random();
            var cpuResponse = random.Next(0, cpuOptions.Length);
            cpuAnswer = cpuOptions[cpuResponse];

            while (killSwitch)
            {
                Console.WriteLine("Please enter either: 'rock'(r), 'paper'(p), 'scissors'(s) or type 'quit(q) to exit.\n\n");
                Console.WriteLine("++++\nCurrent Score: Player: {0} CPU: {1}\n+++++",
                    playerScore, cpuScore);
                var userInput = Console.ReadLine();
                userResponse = userInput.Trim().ToLower();

                if (userResponse == cpuAnswer)
                {
                    Console.Clear();
                    Console.WriteLine("\n=====\nDRAW!\n=====\n");
                    Confirmation();
                }
                else if (userResponse == "scissors" || userResponse == "s")
                {
                    Scissors();
                }
                else if(userResponse == "rock" || userResponse == "r")
                {
                    Rock();
                }
                else if(userResponse == "paper" || userResponse == "p")
                {
                    Paper();
                }
                else if(userResponse == "quit" || userResponse == "q" || userResponse == "exit")
                {
                    Console.WriteLine("Goodbye!");
                    killSwitch = false;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
