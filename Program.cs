using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ROCKPAPERSCISSORS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HELLO WORLD! Let's play a game!");
            var dateTime = new DateTime(2018, 10, 1);
            var now = DateTime.Now;

            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());

            Console.WriteLine("What is your name?: ");
            var name = Console.ReadLine();
            


            string inputPlayer, inputCPU;
            int randomInt;
           
            bool playAgain = true;
 
            while (playAgain)
            {
 
                int scorePlayer = 0;
                int scoreCPU = 0;
 
                while (scorePlayer < 3 && scoreCPU < 3)
                {
                   
 
                    Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();
 
                    Random rnd = new Random();
 
                    randomInt = rnd.Next(1, 4);
 
                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine(name+" WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine(name+" WINS!!\n\n");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine(name+" WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }
 
                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}",scorePlayer, scoreCPU);
 
                }
 
                if (scorePlayer == 3)
                {
                    Console.WriteLine(name+" WON!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON!");
                }
                else
                {
 
                }
 
                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                    Console.WriteLine("Are you sure "+name+" ???");
                    Console.ReadLine();
               }
               else
               {
                   playAgain = false;
               }
 
            }
        }
    }
}