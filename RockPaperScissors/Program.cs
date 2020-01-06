using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            //declare variables
            string inputPlayer, inputCPU;
            int randomInt;

            Console.WriteLine("Choose between Rock, Paper and Scissors:    ");
            inputPlayer = Console.ReadLine();

            Random rand = new Random();

            randomInt = rand.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "Rock";
                    Console.WriteLine("Karen chose Rock");
                    if (inputPlayer == "Rock")
                    {
                        Console.WriteLine("Draw!\n\n");
                    }
                    else if (inputPlayer == "Paper")
                    {
                        Console.WriteLine("Player Wins!\n\n");

                    }
                    else if (inputPlayer == "Scissors")
                    {
                        Console.WriteLine("Karen Wins!\n\n");

                    }
                    break;
                case 2:
                    inputCPU = "Paper";
                    if (inputPlayer == "Scissors")
                    {
                        Console.WriteLine("Karen chose Paper, you win!");
                    }
                    else
                    {
                        Console.WriteLine("Karen chose Paper, try again!");
                    }
                    break;
                case 3:
                    inputCPU = "Scissors";
                    if (inputPlayer == "Rock")
                    {
                        Console.WriteLine("You Win!");
                    }
                    else if (inputPlayer == "Scissors")
                        Console.WriteLine("Karen chose Scissors, try again!");
                    break;
                case 4:
                    inputCPU = "Rock";
                    Console.WriteLine("Karen chose Rock, try again!");
                    break;
            }

        }
    }
}