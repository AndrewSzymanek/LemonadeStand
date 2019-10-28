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

        //constructor

        public Game()
        {
            currentDay = 1;
            
        }

        //member methods
        public void RunGame()
        {
            ChooseAmountOfDays();
            for (currentDay = 1; currentDay <=numberOfDays; currentDay++) { 
            //if (money > 0) 
            //    {

            //run the functions in here if it meets the above criteria

            //    }
            }
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
        public void UserMenu()
        {
            //Display current inventory here? Then ask if they'd like to visit the store to buy things?
        }
        




    }
}
