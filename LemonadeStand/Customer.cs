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
        public List<string> names;
        public string name;
        public int numberChance;
        Random numberChances;

        //constructor
        public Customer(Random random)
        {
            numberChances = random;
        }


        //member methods

        //buy lemonade method

        public void MakePurchaseDecision()
        {

        }
        public void WeatherBasedPurchaseDecision(Weather weather)
        {
            if(weather.condition == "rainy" && weather.temperature >= 70)
            {
                GenerateRandomNumber();
                if(numberChance > 25)
                {

                }
                else
                {

                }
            }
            else if(weather.condition == "rainy" && weather.temperature < 70)
            {
                GenerateRandomNumber();
                if (numberChance < 25)
                {

                }
                else
                {

                }
            }
            else if(weather.condition == "overcast" && weather.temperature >= 80)
            {
                GenerateRandomNumber();
                if (numberChance > 12)
                {

                }
                else
                {

                }
            }
            else if(weather.condition == "overcast" && weather.temperature < 80)
            {
                GenerateRandomNumber();
                if (numberChance > 20)
                {

                }
                else
                {

                }
            }
            else if(weather.condition == "sunny" && weather.temperature > 85)
            {
                GenerateRandomNumber();
                if(numberChance > 5)
                {

                }
                else
                {

                }
            }
            else if(weather.condition == "sunny" && weather.temperature < 85)
            {
                GenerateRandomNumber();
                if(numberChance > 15)
                {

                }
                else
                {

                }
            }
            else if(weather.condition == "thunderstorm" && weather.temperature >= 80)
            {
                GenerateRandomNumber();
                if(numberChance < 4)
                {

                }
                else
                {

                }
            }
            else if(weather.condition == "thunderstorm" && weather.temperature < 80)
            {
                GenerateRandomNumber();
                if(numberChance < 2)
                {

                }
                else
                {

                }
            }
            else if(weather.condition == "partly cloudy" && weather.temperature >= 85)
            {
                GenerateRandomNumber();
                if(numberChance > 6)
                {

                }
                else
                {

                }
            }
            else if(weather.condition == "partly cloudy" && weather.temperature < 85)
            {
                GenerateRandomNumber();
                if(numberChance > 20)
                {

                }
                else
                {

                }

            }
        }
        public void PriceBasedPurchaseDecision(Recipe recipe)
        {
           if(recipe.pricePerCup >= .75)
            {
                GenerateRandomNumber();
                if (numberChance > 40)
                {

                }
                else
                {

                }
            }
           else if(recipe.pricePerCup >= .50)
            {
                GenerateRandomNumber();
                if (numberChance > 25)
                {

                }
                else
                {

                }
            }
           else if(recipe.pricePerCup >= .25)
            {
                GenerateRandomNumber();
                if (numberChance > 12)
                {

                }
                else
                {

                }
            }
           else if(recipe.pricePerCup < .25)
            {
                GenerateRandomNumber();
                if (numberChance > 5)
                {

                }
                else
                {

                }
            }

            //have to pass in day and/or player to be able to access weather and recipe?
        }
        public int GenerateRandomNumber()
        {
            numberChance = numberChances.Next(0, 51);
            return numberChance;
        }

        
    }
}
