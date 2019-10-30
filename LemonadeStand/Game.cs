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
            CreateDays(ChooseAmountOfDays());
            player.recipe.MakeRecipe();
            player.recipe.SetPrice();


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
      
        
        




    }
}
