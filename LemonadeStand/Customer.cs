using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {

        //member variables
        public int numberChance;
        Random numberChances;

        //constructor
        public Customer(Random random)
        {
            numberChances = random;
        }


        //member methods

        //buy lemonade method

        public void MakePurchaseDecision(Player player, Weather weather)
        {
          
            bool weatherAnswer = WeatherBasedPurchaseDecision(weather);
            bool priceAnswer = PriceBasedPurchaseDecision(player.recipe);
            //if it returns true
            if(weatherAnswer == true && priceAnswer == true)
            {
                player.pitcher.CupPoured(player);
                PayForCup(player);
                Console.WriteLine("Purchase!");
                //display money, inventory, cups left, etc.?
            }
            else
            {
                Console.WriteLine("Pass...");
            }
        }
        public bool WeatherBasedPurchaseDecision(Weather weather)
        {
            if(weather.condition == "rainy" && weather.temperature >= 70)
            {
                GenerateRandomNumber();
                if(numberChance > 25)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           
            else if(weather.condition == "rainy" && weather.temperature < 70)
            {
                GenerateRandomNumber();
                if (numberChance < 25)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(weather.condition == "overcast" && weather.temperature >= 80)
            {
                GenerateRandomNumber();
                if (numberChance > 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(weather.condition == "overcast" && weather.temperature < 80)
            {
                GenerateRandomNumber();
                if (numberChance > 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(weather.condition == "sunny" && weather.temperature > 85)
            {
                GenerateRandomNumber();
                if(numberChance > 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(weather.condition == "sunny" && weather.temperature < 85)
            {
                GenerateRandomNumber();
                if(numberChance > 15)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(weather.condition == "thunderstorm" && weather.temperature >= 80)
            {
                GenerateRandomNumber();
                if(numberChance < 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(weather.condition == "thunderstorm" && weather.temperature < 80)
            {
                GenerateRandomNumber();
                if(numberChance < 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(weather.condition == "partly cloudy" && weather.temperature >= 85)
            {
                GenerateRandomNumber();
                if(numberChance > 6)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(weather.condition == "partly cloudy" && weather.temperature < 85)
            {
                GenerateRandomNumber();
                if(numberChance > 20)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
        public bool PriceBasedPurchaseDecision(Recipe recipe)
        {
            
           if(recipe.pricePerCup >= .75)
            {
                GenerateRandomNumber();
                if (numberChance > 40)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           else if(recipe.pricePerCup >= .50)
            {
                GenerateRandomNumber();
                if (numberChance > 25)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           else if(recipe.pricePerCup >= .25)
            {
                GenerateRandomNumber();
                if (numberChance > 12)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
           else if(recipe.pricePerCup < .25)
            {
                GenerateRandomNumber();
                if (numberChance > 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        
        public int GenerateRandomNumber()
        {
            numberChance = numberChances.Next(0, 51);
            return numberChance;
        }
        public void PayForCup(Player player)
        {
            player.wallet.money += player.recipe.pricePerCup;
        }

        
    }
}
