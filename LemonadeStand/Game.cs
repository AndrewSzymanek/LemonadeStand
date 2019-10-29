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

        public Player player;
        public List<Day> days;
        public int currentDay;
        public int numberOfDays;
        public Store store;

        //constructor

        public Game()
        {
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
                days.Add(new Day());
            }
        }
        public void RunGame()
        {
            CreateDays(ChooseAmountOfDays());

            for (int i = 0; i < days.Count; i++)
            {
                days[i].RunDay(player, store);
            }
            //if (money > 0) 
            //    {

            //run the functions in here if it meets the above criteria

            //    }
            
        }
        public int ChooseAmountOfDays()
        {
            Console.WriteLine("How many days would you like to play Lemonade Stand? Enter up to 14 days.");
            numberOfDays = Int32.Parse(Console.ReadLine());
            return numberOfDays;
        }
        public void DisplayDay()
        {

        }
        
        




    }
}
