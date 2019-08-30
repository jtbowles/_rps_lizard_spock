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
        public int numberOfRoundsToPlay = 3;
        public int currentRound = 0;
        public string gameWinner;
        public string roundWinner;
        public bool playAgain;
        public bool isComplete;
        public string userInput;
        public string userInputToLower;
        Player playerOne;
        Player playerTwo;
        List<string> gestureOptions;

        public Game()
        {
            isComplete = false;
            CreateListOfGestures();
        }

        public void GetNumberOfPlayers()
        {
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine("  How many players would like to play?");
            Console.WriteLine("  Enter [1] or [2]");
            Console.WriteLine(" --------------------------------------");

            try
            {
                numberOfPlayers = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(" ----------------------------------------");
                Console.WriteLine("  " + e.Message);
                Console.WriteLine(" ----------------------------------------");
                Console.WriteLine("     please enter a proper response");
                Console.WriteLine(" ----------------------------------------");
                Console.WriteLine("        press [enter] to continue");
                Console.ReadLine();
                Console.Clear();
                GetNumberOfPlayers();
            }
            CheckNumberOfPlayers();
            Console.Clear();
        }

        public void CheckNumberOfPlayers()
        {
            if(numberOfPlayers == 0 || numberOfPlayers > 2)
            {
                Console.Clear();
                Console.WriteLine(" --------------------------------------------------");
                Console.WriteLine("  An appropriate number of players was not selected");
                Console.WriteLine(" --------------------------------------------------");
                Console.WriteLine("           press [enter] to continue");
                Console.ReadLine();
                Console.Clear();
                GetNumberOfPlayers();
            }
        }

        public void DisplayScoreboard()
        {
            Console.Clear();
            Console.WriteLine(" ---------------------------------------------");
            Console.WriteLine("  SCORE SHEET after {0} of {1} possible rounds" , currentRound, numberOfRoundsToPlay);
            Console.WriteLine(" ---------------------------------------------");
            Console.WriteLine("  {0}'s score: {1}", playerOne.name, playerOne.score);
            Console.WriteLine("  {0}'s score: {1}", playerTwo.name, playerTwo.score);
            Console.WriteLine(" ---------------------------------------------");
            Console.WriteLine("         press [enter] to continue");
            Console.Beep();
            Console.ReadLine();
        }

        public void GetGestures(Player player)
        {
            player.ChooseGesture(gestureOptions);
            Console.Clear();
        }

        public void CheckGestures(Player player)
        {
            while (!gestureOptions.Contains(player.gesture))
            {
                Console.WriteLine(" --------------------------------------");
                Console.WriteLine("  Please enter an appropriate response.");
                Console.WriteLine(" --------------------------------------");
                Console.WriteLine("       press [enter] to continue");
                Console.ReadLine();
                Console.Clear();
                player.ChooseGesture(gestureOptions);
                Console.Clear();
            }
        }

        public void EvaluateGestures()
        {
            switch (playerOne.gesture)
            {
                case "rock":
                    if(playerTwo.gesture == "scissors" || playerTwo.gesture == "lizard")
                    {
                        playerOne.score++;
                        currentRound++;
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("  {0} wins! {1} beats {2}", playerOne.name, playerOne.gesture, playerTwo.gesture);
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("    press [enter] to continue");
                        Console.ReadLine();
                    }
                    else if(playerTwo.gesture == "paper" || playerTwo.gesture == "spock")
                    {
                        playerTwo.score++;
                        currentRound++;
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("  {0} wins! {1} beats {2}", playerTwo.name, playerTwo.gesture, playerOne.gesture);
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("    press [enter] to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("  You both picked rock, it's a tie!");
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("     press [enter] to continue");
                        Console.ReadLine();
                    }
                    break;
                case "paper":
                    if (playerTwo.gesture == "rock" || playerTwo.gesture == "spock")
                    {
                        playerOne.score++;
                        currentRound++;
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("  {0} wins! {1} beats {2}", playerOne.name, playerOne.gesture, playerTwo.gesture);
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("     press [enter] to continue");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "scissors" || playerTwo.gesture == "lizard")
                    {
                        playerTwo.score++;
                        currentRound++;
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("  {0} wins! {1} beats {2}", playerTwo.name, playerTwo.gesture, playerOne.gesture);
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("     press [enter] to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("  You both picked paper, it's a tie!");
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("     press [enter] to continue");
                        Console.ReadLine();
                    }
                    break;
                case "scissors":
                    if (playerTwo.gesture == "paper" || playerTwo.gesture == "lizard")
                    {
                        playerOne.score++;
                        currentRound++;
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("  {0} wins! {1} beats {2}", playerOne.name, playerOne.gesture, playerTwo.gesture);
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("     press [enter] to continue");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "rock" || playerTwo.gesture == "spock")
                    {
                        playerTwo.score++;
                        currentRound++;
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("  {0} wins! {1} beats {2}", playerTwo.name, playerTwo.gesture, playerOne.gesture);
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("     press [enter] to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("  You both picked scissors, it's a tie!");
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("     press [enter] to continue");
                        Console.ReadLine();
                    }
                    break;
                case "lizard":
                    if (playerTwo.gesture == "spock" || playerTwo.gesture == "paper")
                    {
                        playerOne.score++;
                        currentRound++;
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("  {0} wins! {1} beats {2}", playerOne.name, playerOne.gesture, playerTwo.gesture);
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("     press [enter] to continue");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "rock" || playerTwo.gesture == "scissors")
                    {
                        playerTwo.score++;
                        currentRound++;
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("  {0} wins! {1} beats {2}", playerTwo.name, playerTwo.gesture, playerOne.gesture);
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("     press [enter] to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("  You both picked lizard, it's a tie!");
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("     press [enter] to continue");
                        Console.ReadLine();
                    }
                    break;
                case "spock":
                    if (playerTwo.gesture == "scissors" || playerTwo.gesture == "rock")
                    {
                        playerOne.score++;
                        currentRound++;
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("  {0} wins! {1} beats {2}", playerOne.name, playerOne.gesture, playerTwo.gesture);
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("     press [enter] to continue");
                        Console.ReadLine();
                    }
                    else if (playerTwo.gesture == "lizard" || playerTwo.gesture == "paper")
                    {
                        playerTwo.score++;
                        currentRound++;
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("  {0} wins! {1} beats {2}", playerTwo.name, playerTwo.gesture, playerOne.gesture);
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("     press [enter] to continue");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("  You both picked spock, it's a tie!");
                        Console.WriteLine(" --------------------------------------");
                        Console.WriteLine("     press [enter] to continue");
                        Console.ReadLine();
                    }
                    break;
                default:
                    Console.WriteLine("You found an Easter Egg!");
                    Console.ReadLine();
                    break;
            }
        }

        public void GeneratePlayers()
        {
            if(numberOfPlayers == 1)
            {
                playerOne = new Human("Player One");
                playerTwo = new Computer();
            }
            else if(numberOfPlayers == 2)
            {
                playerOne = new Human("Player One");
                playerTwo = new Human("Player Two");
            }
            SetPlayerName(playerOne);
            SetPlayerName(playerTwo);
        }

        public void SetPlayerName(Player player)
        {
            while(player.name == "")
            {
                player.ChooseName();
                Console.Clear();
            }
        }

        public void DisplayPlayerNames()
        {
            Console.WriteLine(" -------------------------------------------------------------");
            Console.WriteLine("  Player One's name is: {0} | Player Two's name is: {1}", playerOne.name, playerTwo.name);
            Console.WriteLine(" -------------------------------------------------------------");
            Console.WriteLine("                 press [enter] to continue");
            Console.Read();
            Console.Clear();
        }

        public void DisplayNumberOfPlayers()
        {
            Console.WriteLine(" -------------------------------------");
            Console.WriteLine("  Currently playing with {0} player(s)", numberOfPlayers);
            Console.WriteLine(" -------------------------------------");
            Console.WriteLine("      press [enter] to continue");
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
            Console.WriteLine(" -----------------------------------------------------------------------------------");
            Console.WriteLine("  You will get the opportunity to choose your gesture between each of the following:");
            Console.WriteLine(" -----------------------------------------------------------------------------------");

            foreach (string gesture in gestureOptions)
            {
                Console.WriteLine("    " + gesture);
            }

            //gestureOptions.ForEach(Console.WriteLine);

            Console.WriteLine(" -----------------------------------------------------------------------------------");
            Console.WriteLine("                              press [enter] to continue");
            Console.ReadLine();
        }

        public void DisplayWelcome()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("  WELCOME TO Rock-Paper-Scissors-Lizard-Spock!!!");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("           press [enter] to continue");
            Console.Read();
            Console.Beep();
            Console.Clear();
        }

        public void DisplayGameRules()
        {
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine("  The rules of the game are as follows:");
            Console.WriteLine(" --------------------------------------");
            Console.WriteLine("     Rock crushes Scissors");
            Console.WriteLine("     Rock crushes Lizard");
            Console.WriteLine();
            Console.WriteLine("     Paper covers Rock");
            Console.WriteLine("     Paper disproves Spock");
            Console.WriteLine();
            Console.WriteLine("     Scissors cuts Paper");
            Console.WriteLine("     Scissors decapitates Lizard");
            Console.WriteLine();
            Console.WriteLine("     Lizard poisons Spock");
            Console.WriteLine("     Lizard eats Paper");
            Console.WriteLine();
            Console.WriteLine("     Spock smashes Scissors");
            Console.WriteLine("     Spock vaporizes Rock");
            Console.WriteLine(" --------------------------------------");
            Console.ReadLine();
        }

        public void GetNumberOfRounds()
        {
            Console.Clear();
            Console.WriteLine(" --------------------------------------------------------------");
            Console.WriteLine("  Enter an ODD NUMBER for the amount of rounds you wish to play");
            Console.WriteLine("        *minimum best of 3*     *maximum best of 21*");
            Console.WriteLine(" --------------------------------------------------------------");

            try
            {
                numberOfRoundsToPlay = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.ReadLine();
                GetNumberOfRounds();
            }
            Console.Clear();
        }

        public void DisplayGameWinner()
        {
            Console.WriteLine("  ------------------------------");
            Console.WriteLine("  Congrats {0}! You won the game!", gameWinner);
            Console.WriteLine("  ------------------------------");
        }

        public void CheckNumberOfRounds()
        {
            if(numberOfRoundsToPlay < 3 || numberOfRoundsToPlay % 2 == 0 || numberOfRoundsToPlay > 21)
            {
                numberOfRoundsToPlay = 3;
                Console.WriteLine(" --------------------------------------------------------------------------");
                Console.WriteLine("  An appropriate amount of rounds was not entered. Initialized to 3 rounds.");
                Console.WriteLine(" --------------------------------------------------------------------------");
                Console.WriteLine("                       press [enter] to continue");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void RunGame()
        {
            DisplayWelcome();
            DisplayGameRules();
            GetNumberOfPlayers();
            DisplayNumberOfPlayers();
            DisplayListOfGestures();
            Console.ReadLine();
            Console.Clear();
            GeneratePlayers();
            DisplayPlayerNames();
            Console.Read();
            GetNumberOfRounds();
            CheckNumberOfRounds();

            while (currentRound <= numberOfRoundsToPlay)
            {
                if(playerOne.score > numberOfRoundsToPlay / 2 || playerTwo.score > numberOfRoundsToPlay / 2)
                {
                    if(playerOne.score > playerTwo.score)
                    {
                        gameWinner = playerOne.name;
                        break;
                    }
                    else if (playerTwo.score > playerOne.score)
                    {
                        gameWinner = playerTwo.name;
                        break;
                    }
                }
                else
                {
                    RunRound();
                    DisplayScoreboard();
                    Console.Clear();
                }
            }
            DisplayScoreboard();
            Console.Clear();
            DisplayGameWinner();
            Console.Read();
        }

        public void RunRound()
        {
            GetGestures(playerOne);
            CheckGestures(playerOne);
            GetGestures(playerTwo);
            CheckGestures(playerTwo);
            EvaluateGestures();
        }

        public void PlayAgain()
        {
            Console.Clear();
            Console.WriteLine(" ------------------------------");
            Console.WriteLine("  Would you care to play again?");
            Console.WriteLine(" ------------------------------");
            Console.WriteLine("      enter [yes] or [no]");
            Console.Read();
            userInput = Console.ReadLine();
            userInputToLower = userInput.ToLower();

            if(userInputToLower == "yes")
            {
                playAgain = true;
            }
            else if(userInputToLower == "no")
            {
                playAgain = false;
            }
            else /*if (userInput != "yes" || userInput != "no")*/
            {
                Console.Clear();
                Console.WriteLine(" --------------------------------------");
                Console.WriteLine("  Please select an appropriate response");
                Console.WriteLine(" --------------------------------------");
                Console.WriteLine("      press [enter] to continue");
                Console.Read();
                PlayAgain();
            }
        }
    }
}
