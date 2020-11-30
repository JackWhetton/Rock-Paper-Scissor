using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockWins
{
    class program
    {
        static void Main(string[] args)
        {
            string inputUser, inputComputer; // input Values.
            int randomInt;

            bool Playagain = true;

            while (Playagain)
            {
                int userScore = 0; // move here to enable to keep score, when played again.
                int computerScore = 0;


                while (userScore < 3 && computerScore < 3)
                {



                    Console.WriteLine(" Choose Rock, Paper or Scissors    "); // asking the user tp input there value.
                    inputUser = Console.ReadLine(); // asking the computer to read the user value.
                    inputUser = inputUser.ToUpper();// enable upper case letters " i think"
                    Random rnd = new Random(); // Create a Random Value for the computer to choice.

                    randomInt = rnd.Next(1, 4); // value choice for the computer is between 1 & 4.

                    switch (randomInt) 
                    {
                        case 1:
                            inputComputer = "rock";
                            Console.WriteLine("computer has chosen Rock");
                            if (inputUser == "rock") // just in case the user and computer chose the same answer.
                            {
                                Console.WriteLine("Draw   \n\n");
                            }
                            else if (inputUser == "paper") // Other possible outcomes
                            {
                                Console.WriteLine("Player Wins \n\n");
                                userScore++;
                            }
                            else if (inputUser == "Scissor")
                            {
                                Console.WriteLine("Computer wins \n\n");
                                computerScore++;
                            }
                            break;

                        case 2:
                            inputComputer = "paper";
                            Console.WriteLine("computer has chosen Paper");
                            if (inputUser == "Paper") // just in case the user and computer chose the same answer.
                            {
                                Console.WriteLine("Draw \n\n");
                            }
                            else if (inputUser == "Rock") // Other possible outcomes
                            {
                                Console.WriteLine("Computer Wins!! \n\n");
                                userScore++;
                            }
                            else if (inputUser == "Scissor")
                            {
                                Console.WriteLine("Player Wins!! \n\n");
                                computerScore++;
                            }
                            break;

                        case 3:
                            inputComputer = "scissors";
                            Console.WriteLine("computer has chosen scissors");
                            if (inputUser == "scissors") // just in case the user and computer chose the same answer.
                            {
                                Console.WriteLine("Draw \n\n");
                            }
                            else if (inputUser == "paper") // Other possible outcomes
                            {
                                Console.WriteLine("Computer Wins!! \n\n");
                                userScore++;
                            }
                            else if (inputUser == "Rock")
                            {
                                Console.WriteLine("Player Wins!! \n\n");
                                computerScore++;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid entry"); // if ther input a invalid value

                            break;
                    }

                }

                if (userScore == 3) // display text on winner 
                {
                    Console.WriteLine(" User Wins !! \n\n");
                }
                else if (computerScore == 3)
                {
                    Console.WriteLine(" Computer Wins !! \n\n");
                }
                else
                {

                }
                Console.WriteLine(" Do you want to play again? (Y/N) "); // loop to enable play again option.
                String loop = Console.ReadLine();
                if (loop == "y")
                {
                    Playagain = true; // change varaiable name 
                }
                else if (loop == "n")
                {
                    Playagain = false;
                }


            }
        }
    }
}
