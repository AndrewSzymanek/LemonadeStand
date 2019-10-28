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
            for (currentDay = 1; currentDay <=numberOfDays; currentDay++)
            {if (money > 0)
                {

                }

            }
            

        }
        public int ChooseAmountOfDays()
        {
            Console.WriteLine("Would you like to play 7 days or 14 days of Lemonade Stand? Enter '7' or '14'.");
            numberOfDays = Int32.Parse(Console.ReadLine());
            return numberOfDays;

        }
        public void DisplayDay()
        {

        }




    }
}
