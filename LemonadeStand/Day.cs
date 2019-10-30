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
        public Day(Random random)
        {
            weather = new Weather(random);
            customers = new List<Customer>();
            GenerateCustomers(random);
        }

        //member methods
        public void RunDay(Player player, Store store) 
        {
            DisplayWeather();
            UserMenu(player, store);

        }
        public void DisplayWeather()
        {
            
            Console.WriteLine("Today's weather condition is" + " " + weather.condition + ".") ;
            Console.WriteLine("Today's temperature is" + " " + weather.temperature + " degrees Fahrenheit.");
        }
        public void UserMenu(Player player, Store store)
        {

            Console.WriteLine("Would you like to check inventory, check wallet or go to the store? Type 'inventory', 'wallet', or 'store'. Type 'stop' to move on.");
            string menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "inventory":
                    player.inventory.DisplayInventory();
                    UserMenu(player, store);
                    break;
                case "wallet":
                    player.wallet.DisplayMoney();
                    UserMenu(player, store);
                    break;
                case "store":
                    store.WhichItemToBuy();
                    UserMenu(player, store);
                    break;
                case "stop":
                    break;
            }
        }
        private void GenerateCustomers(Random random)
        {
            //50-150 customers randomly generated- new instances of a Customer object
            //for loop adds a new customer object 
            //random parameter

            int randomNum = random.Next(50, 151);
            for(int i = 1; i < randomNum; i++)
            {
                customers.Add(new Customer());
            }
        }

       
    }
}
