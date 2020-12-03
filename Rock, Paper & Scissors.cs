using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
                string inputPlayer, inputAI; //input values
                int randomInt;

                bool playAgain = true; 

                while (playAgain)
                {
                    // scoring variables
                    int scorePlayer = 0; 
                    int scoreAI = 0;

                    while (scorePlayer < 3 && scoreAI < 3) //First to three wins is the winner
                    {


                        Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");
                        inputPlayer = Console.ReadLine(); // reads the player choices 
                        inputPlayer = inputPlayer.ToUpper(); // reads upper case letters

                        Random rnd = new Random();

                        randomInt = rnd.Next(1, 4); // random varaible that enbale the AI to choose between 1 to 4

                        switch (randomInt)
                        {
                            case 1: // The possible outcome for Rock
                            inputAI = "ROCK";
                                Console.WriteLine("Computer chose ROCK");
                                if (inputPlayer == "ROCK")
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "PAPER")
                                {
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "SCISSORS")
                                {
                                    Console.WriteLine("CPU WINS!!\n\n");
                                    scoreAI++;
                                }
                                break;
                            case 2: // The possible outcome for Paper
                                inputAI = "PAPER";
                                Console.WriteLine("Computer chose PAPER");
                                if (inputPlayer == "PAPER")
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "ROCK")
                                {
                                    Console.WriteLine("CPU WINS!!\n\n");
                                    scoreAI++;
                                }
                                else if (inputPlayer == "SCISSORS")
                                {
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                break;
                            case 3: // The Possible outcome for Scissors
                                inputAI = "SCISSORS";
                                Console.WriteLine("Computer chose SCISSORS");
                                if (inputPlayer == "SCISSORS")
                                {
                                    Console.WriteLine("DRAW!!\n\n");
                                }
                                else if (inputPlayer == "ROCK")
                                {
                                    Console.WriteLine("PLAYER WINS!!\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "PAPER")
                                {
                                    Console.WriteLine("CPU WINS!!\n\n");
                                    scoreAI++;
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid entry!");
                                break;
                        }
                        // This code will displaying of current scores until there a winners.
                        Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreAI);

                    }
                    // This program will display text if either player or AI scores reaches three.
                    if (scorePlayer == 3)
                    {
                        Console.WriteLine("Player WON!");
                    }
                    else if (scoreAI == 3)
                    {
                        Console.WriteLine("AI WON!");
                    }
                    else
                    {

                    }
                    // This code will execute when game ends, asking player if they want to player again.
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
                    }
                    else
                    {

                    }

                }
            }
        }
    
    }

