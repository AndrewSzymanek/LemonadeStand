using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        //member variables
        public Random random;
        public Player player;
        public List<Day> days;
        public int currentDay;
        public int numberOfDays;
        public Store store;

        //constructor

        public Game()
        {
            random = new Random();
            days = new List<Day>();
            currentDay = 1;
            player = new Player();
            store = new Store(player);
        }

        //member methods
        public void CreateDays(int numbDays)
        {

            for (int i = 0; i < numbDays; i++)
            {
                days.Add(new Day(random));
            }
        }
        public void RunGame()
        {
            DisplayRules();
            CreateDays(ChooseAmountOfDays());
            player.recipe.MakeRecipe();

            if (player.wallet.money > 0)
            {
                for (int i = 0; i < days.Count; i++)
                {
                    days[i].RunDay(player, store, random);
                }
            }
        }
        public int ChooseAmountOfDays()
        {
            Console.WriteLine(player.name + ", how many days would you like to play Lemonade Stand? Enter up to 14 days.");

            
                numberOfDays = Int32.Parse(Console.ReadLine());
  
            return numberOfDays;
        }
      
        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Lemonade Stand where the goal is to have as many passersby purchase your lemonade.\n First, you will choose how long you'd like to play the game.\nThen, you will decide your special recipe.");
            Console.WriteLine("After choosing your recipe and price, you will be shown the first day's weather.\nBased off of the weather, you will choose your price of lemonade.\nIf it's sunny and hot, jack that price up! If it's cool and/or rainy, lower that price.");
            Console.WriteLine("When the price is set, you're able to start stocking up for your inventory of items to make pitchers of lemonade and sell them to customers.\nAfter your inventory is stocked up, you should go ahead and make a pitcher.\nYou can't make a pitcher without buying some items first.");
            Console.WriteLine("Finally, enter 'continue' to see how many passersby you have that day and watch some of them buy from you or pass you buy.");
        }
        




    }
}
