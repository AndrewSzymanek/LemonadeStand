using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {

        //member variables
        public string condition;
        public int temperature;
        public List<string> weatherConditions;
        Random temperatures;

        //constructor

        public Weather(Random random)
        {
            weatherConditions = new List<string>(){"rainy", "overcast", "sunny", "thunderstorm", "partly cloudy"};
            temperatures = random;
            
            
            GenerateWeatherCondition(random);
            GenerateTemp();
        }


        //member methods
        //SOLID PRINCIPLE- open/closed principle- the GenerateWeatherCondition method is closed to modification because it's doing one thing generating the random weather.
        //However, if we wanted to add conditions to the list to be able to choose from a broader list of options, we could. (say there could be a hurricane or an earthquake depending on the location of the game)
        public void GenerateWeatherCondition(Random random)
        {
            int randomWeather = random.Next(0, weatherConditions.Count);
            condition = weatherConditions[randomWeather];
         

        }
        public void GenerateTemp()
        {
            temperature = temperatures.Next(60, 105);
            
          
        }
    }
}
