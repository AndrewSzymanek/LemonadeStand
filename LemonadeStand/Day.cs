using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {

        //member variables
        public Weather weather;
        public List<Customer> customers;

        //constructor
        public Day()
        {
            weather = new Weather();
        }


        //member methods
        public void RunDay(Player player, Store store) 
        {
            UserMenu(player, store);
            //call user menu
        }
        public void DisplayWeather()
        {
            Console.WriteLine("Today's weather condition is" + " " + weather.condition);
            Console.WriteLine("Today's temperature is" + " " + weather.temperature + "degrees Fahrenheit.");
        }
        public void UserMenu(Player player, Store store)
        {
            Console.WriteLine("Would you like to check inventory or go to the store? Type 'inventory' or 'store'.");
            string menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "inventory":
                    player.inventory.DisplayInventory();
                    break;
                case "store":
                    store.WhichItemToBuy();
                    break;

            }
        }
    }
}
