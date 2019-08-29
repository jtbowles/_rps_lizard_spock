using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        public int numberOfPlayers;
        Player playerOne;
        Player playerTwo;
        List<string> gestureOptions;

        public Game()
        {
            CreateListOfGestures();
        }

        public void GetNumberOfPlayers()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("How many players would like to play?");
            Console.WriteLine("Enter [1] or [2]");
            Console.WriteLine("-----------------------------------");
            numberOfPlayers = Int32.Parse(Console.ReadLine());
            Console.Clear();
        }

        public void DisplayScoreboard()
        {
            Console.WriteLine("SCORE SHEET");
            Console.WriteLine("------------");
            Console.WriteLine("{0}'s score: {1}", playerOne.name, playerOne.score);
            Console.WriteLine("{0}'s score: {1}", playerTwo.name, playerTwo.score);
            Console.ReadLine();
        }

        public void GetGestures()
        {
            playerOne.ChooseGesture(gestureOptions);
            Console.Clear();

            playerTwo.ChooseGesture(gestureOptions);
            Console.Clear();
            Console.WriteLine("Player one's gesture is {0} | Player two's gesture is {1}", playerOne.gesture, playerTwo.gesture);
            Console.ReadLine();
        }

        public void EvaluateGestures()
        {
            switch (playerOne.gesture)
            {
                case "rock":
                    if(playerTwo.gesture == "scissors" || playerTwo.gesture == "lizard")
                    {
                        playerOne.score++;
                        Console.WriteLine("Player 1 wins!");
                        Console.ReadLine();
                    }
                    else if(playerTwo.gesture == "paper" || playerTwo.gesture == "spock")
                    {
                        playerTwo.score++;
                        Console.WriteLine("Player 2 wins!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You both picked rock, it's a tie!");
                        Console.ReadLine();
                    }
                    break;
                case "paper":
                    if (playerTwo.gesture == "rock" || playerTwo.gesture == "spock")
                    {
                        playerOne.score++;
                        Console.WriteLine("Player 1 wins!");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "scissors" || playerTwo.gesture == "lizard")
                    {
                        playerTwo.score++;
                        Console.WriteLine("Player 2 wins!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You both picked paper, it's a tie!");
                        Console.ReadLine();
                    }
                    break;
                case "scissors":
                    if (playerTwo.gesture == "paper" || playerTwo.gesture == "lizard")
                    {
                        playerOne.score++;
                        Console.WriteLine("Player 1 wins!");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "rock" || playerTwo.gesture == "spock")
                    {
                        playerTwo.score++;
                        Console.WriteLine("Player 2 wins!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You both picked scissors, it's a tie!");
                        Console.ReadLine();
                    }
                    break;
                case "lizard":
                    if (playerTwo.gesture == "spock" || playerTwo.gesture == "paper")
                    {
                        playerOne.score++;
                        Console.WriteLine("Player 1 wins!");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "rock" || playerTwo.gesture == "scissors")
                    {
                        playerTwo.score++;
                        Console.WriteLine("Player 2 wins!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You both picked lizard, it's a tie!");
                        Console.ReadLine();
                    }
                    break;
                case "spock":
                    if (playerTwo.gesture == "scissors" || playerTwo.gesture == "rock")
                    {
                        playerOne.score++;
                        Console.WriteLine("Player 1 wins!");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "lizard" || playerTwo.gesture == "paper")
                    {
                        playerTwo.score++;
                        Console.WriteLine("Player 2 wins!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You both picked spock, it's a tie!");
                        Console.ReadLine();
                    }
                    break;
                default:
                    break;
            }
        }

        public void GeneratePlayers()
        {
            if(numberOfPlayers == 1)
            {
                playerOne = new Human();
                playerTwo = new Computer();
            }
            else if(numberOfPlayers == 2)
            {
                playerOne = new Human();
                playerTwo = new Human();
            }
            SetPlayerName(playerOne);
            SetPlayerName(playerTwo);
        }

        public void SetPlayerName(Player player)
        {
            player.ChooseName();
            Console.Clear();
        }

        public void DisplayPlayerNames()
        {
            Console.WriteLine("Player One's name is: {0} | Player Two's name is: {1}", playerOne.name, playerTwo.name);
            Console.Read();
            Console.Clear();
        }

        public void DisplayNumberOfPlayers()
        {
            Console.WriteLine("Currently playing with {0} player(s)", numberOfPlayers);
            Console.Read();
            Console.Clear();
        }

        public void CreateListOfGestures()
        {
            gestureOptions = new List<string>();
            gestureOptions.Add("rock");
            gestureOptions.Add("paper");
            gestureOptions.Add("scissors");
            gestureOptions.Add("lizard");
            gestureOptions.Add("spock");

        }



        public void DisplayListOfGestures()
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("You will get the opportunity to choose your gesture between each of the following:");
            Console.WriteLine("----------------------------------------------------------------------------------");


            foreach (string gestures in gestureOptions)
            {
                Console.WriteLine(gestures);
            }
            Console.ReadLine();
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("WELCOME TO Rock-Paper-Scissors-Lizard-Spock!!!");
            Console.WriteLine("----------------------------------------------");
            Console.Read();
            Console.Clear();
        }

        public void DisplayGameRules()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("The rules of the game are as follows:");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Rock crushes Scissors");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine();
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine();
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine();
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine();
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Spock vaporizes Rock");
            Console.ReadLine();
        }

        public void RunGame()
        {
            DisplayWelcome();
            DisplayGameRules();
            GetNumberOfPlayers();
            DisplayNumberOfPlayers();
            DisplayListOfGestures();
            GeneratePlayers();
            DisplayPlayerNames();
            Console.Read();
            GetGestures();
            EvaluateGestures();

            Console.Read();


        }
    }
}
