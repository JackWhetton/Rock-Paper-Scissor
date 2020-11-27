using System;

namespace RockWins
{
    class Program
    {
        static void Main(string[] args)
        {
            string userinput, Computerinput; // input Values.
            int randomInt;

            bool Playagain = true;

            while (Playagain)
            {
                int UserScore = 0; // move here to enable to keep score, when played again.
                int ComputerScore = 0;


                while (UserScore < 3 && ComputerScore < 3)
                {



                    Console.WriteLine(" Choose Rock, Paper or Scissors    "); // asking the user tp input there value.
                    userinput = Console.ReadLine(); // asking the computer to read the user value.
                    userinput = userinput.ToUpper();// enable upper case letters " i think"
                    Random rnd = new Random(); // Create a Random Value for the computer to choice.

                    randomInt = rnd.Next(1, 4); // value choice for the computer is between 1 & 4.

                    switch (randomInt) // creating the values for RandomInt
                    {
                        case 1:
                            userinput = "rock";
                            Console.WriteLine("computer has chosen Rock");
                            if (userinput == "rock") // just in case the user and computer chose the same answer.
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (userinput == "paper") // Other possible outcomes
                            {
                                Console.WriteLine("Player Wins");
                                UserScore++;
                            }
                            else if (userinput == "Scissor")
                            {
                                Console.WriteLine("Computer wins");
                                ComputerScore++;
                            }
                            break;

                        case 2:
                            userinput = "paper";
                            Console.WriteLine("computer has chosen Paper");
                            if (userinput == "Paper") // just in case the user and computer chose the same answer.
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (userinput == "Rock") // Other possible outcomes
                            {
                                Console.WriteLine("Player Wins");
                                UserScore++;
                            }
                            else if (userinput == "Scissor")
                            {
                                Console.WriteLine("Computer wins");
                                ComputerScore++;
                            }
                            break;

                        case 3:
                            userinput = "scissors";
                            Console.WriteLine("computer has chosen scissors");
                            if (userinput == "scissors") // just in case the user and computer chose the same answer.
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (userinput == "paper") // Other possible outcomes
                            {
                                Console.WriteLine("Player Wins");
                                UserScore++;
                            }
                            else if (userinput == "Rock")
                            {
                                Console.WriteLine("Computer wins");
                                ComputerScore++;
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid entry"); // if ther input a invalid value

                            break;
                    }

                }

                if (UserScore == 3) // display text on winner 
                {
                    Console.WriteLine(" User Wins !!");
                }
                else if (ComputerScore == 3)
                {
                    Console.WriteLine(" Computer Wins !!");
                }
                else
                {

                }
                Console.WriteLine(" Do you want to play again? (Y/N) "); // loop to enable play again option.
                String loop = Console.ReadLine();
                if (loop == "y")
                {
                    Playagain = true;
                }
                else if (loop == "n")
                {
                    Playagain = false;
                }


            }
        }
    }
}
