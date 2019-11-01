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
        public void RunDay(Player player, Store store, Random random) 
        {
            Console.WriteLine("Welcome to a new day!" );
            DisplayWeather();
            player.recipe.SetPrice();
            UserMenu(player, store);
            Console.WriteLine("You have " + customers.Count + " potential customers today.");
            foreach (Customer customer in customers)
            {
                if(player.pitcher.cupsLeftInPitcher > 0)
                {
                    customer.MakePurchaseDecision(player, weather);
                }
                else if(player.pitcher.cupsLeftInPitcher == 0)
                {
                    if(player.CheckInventoryForPitcher() == true)
                    {
                        player.MakePitcher();
                    }
                    else
                    {
                        break;
                    }  
                }              
            }
            EndOfDayDisplay(player);
            
           
        }
        public void DisplayWeather()
        {
            
            Console.WriteLine("Today's weather condition is" + " " + weather.condition + ".") ;
            Console.WriteLine("Today's temperature is" + " " + weather.temperature + " degrees Fahrenheit.");
        }
        public void UserMenu(Player player, Store store)
        {

            Console.WriteLine("Would you like to check inventory, check wallet or go to the store? Type 'inventory', 'wallet', or 'store'.\nAfter you've stocked up your inventory, type 'make pitcher' to get ready for customers then type 'continue' to move on.");
            string menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
            //Do I want to make sure they can't move on before filling up their inventory? Probably 
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
                case "make pitcher":
                    player.MakePitcher();
                    UserMenu(player, store);
                    break;
                case "continue":
                    break;
                default:
                    Console.WriteLine("Please type a valid response.");
                    UserMenu(player, store);
                    break;
            }
        }
        private void GenerateCustomers(Random random)
        {
                int randomNum = random.Next(30, 51);
                for (int i = 1; i < randomNum; i++)
                {
                    customers.Add(new Customer(random));
                }
        }
        private void EndOfDayDisplay(Player player)
        {
            Console.WriteLine("You spent " + player.wallet.moneySpentInventoryToday + " dollars on inventory today.");
            Console.WriteLine("You made " + player.wallet.earnedMoneyToday + " dollars today.");
            Console.WriteLine("Today's profit/loss is: " + (player.wallet.earnedMoneyToday - player.wallet.moneySpentInventoryToday));
            Console.WriteLine("You have spent " + player.wallet.moneySpentInventoryTotal + " dollars on inventory thus far.");
            Console.WriteLine("Total profit/loss is: " + player.wallet.earnedMoneyTotal + ".");
            player.wallet.moneySpentInventoryToday = 0;
            NewMoneyInPot(player);
        }

        private void NewMoneyInPot(Player player)
        {
            player.wallet.money += player.wallet.earnedMoneyToday;
            player.wallet.earnedMoneyToday = 0;
        }
    }
}
