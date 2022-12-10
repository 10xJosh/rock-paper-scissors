using System;
using System.IO;

namespace RockPaperScissorsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new RockPaperScissors();

            game.runGame();
        }
    }
}
