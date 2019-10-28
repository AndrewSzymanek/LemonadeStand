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
        public Random random;
        public List<string> weatherConditions;
        public List<int> temperatures;

        //constructor

        public Weather()
        {
            weatherConditions = new List<string>(){"rainy", "overcast", "sunny", "thunderstorm", "partly cloudy"};
            temperatures = new List<int>() {65, 70, 78, 85, 97};
            random = new Random();
            random = new Random();
        }


        //member methods
        public string GenerateWeatherCondition()
        {
            int randomWeather = random.Next(0, weatherConditions.Count);
            condition = weatherConditions[randomWeather];
            return condition;

        }
        public int GenerateTemp()
        {
            int randomTemp = random.Next(0, temperatures.Count);
            temperature = temperatures[randomTemp];
            return temperature;
        }
    }
}
