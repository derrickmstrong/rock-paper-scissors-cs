using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string inputPlayer = "";
            string inputCPU = "";
            int randomInt;
            bool playAgain = true;
            string loop = "";

            while (playAgain)
            {
                // Place scores inside the while loop so that it resets on playAgain
                int scorePlayer = 0;
                int scoreCPU = 0;

                // Keep playing until someone wins 3 times
                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    Console.WriteLine($"Player: {scorePlayer} | CPU: {scoreCPU} ");
                    Console.Write("Choose between ROCK, PAPER and SCISSORS: (or \"q\" to quit) ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();
                    Console.WriteLine($"\nPLAYER chose {inputPlayer}");

                    // Check if player wants to quit game w/ "q"
                    if (inputPlayer == "Q")
                    {
                        //playAgain = false;
                        break;
                    }

                    // Setup random int
                    Random rnd = new Random(); // Uses Random class
                    randomInt = rnd.Next(1, 4); // Gives you a random number between certain range

                    // Take the randomInt and display a different message based on the case
                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine($"CPU chose {inputCPU}");
                            if (inputPlayer == inputCPU)
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Player Wins!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU Wins!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine($"CPU chose {inputCPU}");
                            if (inputPlayer == inputCPU)
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("Player Wins!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU Wins!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine($"CPU chose {inputCPU}");
                            if (inputPlayer == inputCPU)
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("Player Wins!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU Wins!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry!");
                            break;
                    }
                }
                // Check for end of game
                isEndOfGame(scorePlayer, scoreCPU, inputPlayer);
                // Check for playAgain
                Console.Write("Play again? y/n  ");
                loop = Console.ReadLine();
                if (loop == "y")
                {
                    Console.WriteLine("\n\n");
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    Console.WriteLine("\n\n");
                    playAgain = false;
                    Console.Clear();
                }
            }
        }

        // Methods
        static void isEndOfGame(int scorePlayer, int scoreCPU, string inputPlayer)
        {
            if (scorePlayer == 3)
            {
                Console.WriteLine("Player wins game!!! \n\n");
            }
            else if (scoreCPU == 3)
            {
                Console.WriteLine("CPU wins game!!!\n\n");
            }
            else if (inputPlayer == "Q")
            {
                Console.WriteLine("Oh, don't be a quiter. Maybe next time!!!\n\n");
            }
        }
    }
}
