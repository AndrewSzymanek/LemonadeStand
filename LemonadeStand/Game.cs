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

        //constructor

        public Game()
        {

        }

        //member methods
        public void RunGame()
        {
            ChooseAmountOfDays();

        }
        public string ChooseAmountOfDays()
        {
            Console.WriteLine("Would you like to play 7 days or 14 days of Lemonade Stand? Enter '7' or '14'.");
            string result = Console.ReadLine();
            return result;

        }
        public void DisplayDay()
        {

        }




    }
}
