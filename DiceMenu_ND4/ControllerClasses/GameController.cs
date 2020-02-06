using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceMenu_ND4.ControllerClasses
{
    class GameController
    {
        public void StartGame(int playerCount, int diceCount)
        {
            Console.WriteLine($"Player count: {playerCount} , dice count: {diceCount}");
            GameScreen myGame = new GameScreen(30, 20);
            // myGame.SetHero(new Hero(5, 5, "HERO"));

            // create round
            Random rnd = new Random();
            int roundNumber = 1;
            bool winnerIsFound = false;

            while (!winnerIsFound)
            {
                // Creating players array according to playerCount 
                string[] players = new string[playerCount];

                int[] diceResult = new int[diceCount];
                int[] results = new int[playerCount];
                for (int i = 0; i < playerCount; i++)
                {
                    players[i] = $"Player Nr {i + 1}";
                }

                //gameplay and results
                Console.WriteLine($"Round nr {roundNumber}");
                Console.WriteLine("Player list |" + diceText(diceCount) + " Total");
                Console.WriteLine("");
                for (int i = 0; i < players.Length; i++)
                {
                    Console.Write(players[i] + " |");

                    int result = 0;

                    //dice count
                    for (int j = 0; j < diceCount; j++)
                    {
                        diceResult[j] = rnd.Next(1, 6);
                        result += diceResult[j];
                        Console.Write("     " + diceResult[j] + " |");

                    }

                    //display results of current player
                    Console.Write("     " + result + " |");

                    // put this result value into results array
                    results[i] = result;

                    Console.WriteLine("");
                }
                Console.WriteLine("");

                var max = results.Select((n, i) => (Number: n, Index: i)).Max();

                //creating new array from original using only max value
                int[] v = results.Select((b, i) => b == largest(results) ? i : -1).Where(i => i != -1).ToArray();
                if (v.Length > 1)
                {
                    //new round
                    winnerIsFound = false;
                    roundNumber++;
                }
                else
                {
                    Console.WriteLine($"Winner is {players[max.Index]} !");
                    winnerIsFound = true;
                }
            }

            Console.ReadKey();
        }
        public string diceText(int diceCount)
        {
            string returnText = "";
            for (int i = 0; i < diceCount; i++)
            {
                returnText = returnText + $"Dice {i+1} | ";
            }
            return returnText;
        }
        
        public int largest(int [] resultsTest)
        {
            int i;

            // Initialize maximum element 
            int max = resultsTest[0];

            // Traverse array elements from second and 
            // compare every element with current max  
            for (i = 1; i < resultsTest.Length; i++)
                if (resultsTest[i] >= max)
                    max = resultsTest[i];

            return max;
        }
        
    }
}
