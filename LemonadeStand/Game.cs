using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        // member variables
        Random random;
        Player player;
        Store store;
        Weather weather;
        private double score = 0;
        private int numberOfDays = 7;

        // constructor
        public Game()
        {
            DisplayRules();
            Player player = new Player();
            GameOptions();
            random = new Random(); 
        }

        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand. Where you sell the most expensive lemonade ever!");
            Console.WriteLine("At a minimum, you will choose from seven days and up to sell as much lemonade as possible.");
            Console.WriteLine("You will be given a forecast of the weather that will determine how many customers buy your lemonade on a given day.");

        }

        public void GameOptions()
        {

        }
    }
}
