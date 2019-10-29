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
        public List<int> temperatures;

        //constructor

        public Weather(Random random)
        {
            weatherConditions = new List<string>(){"rainy", "overcast", "sunny", "thunderstorm", "partly cloudy"};
            temperatures = new List<int>() {65, 70, 78, 85, 97};
            
            
            GenerateWeatherCondition(random);
            GenerateTemp(random);
        }


        //member methods
        public void GenerateWeatherCondition(Random random)
        {
            int randomWeather = random.Next(0, weatherConditions.Count);
            condition = weatherConditions[randomWeather];
         

        }
        public void GenerateTemp(Random random)
        {
            int randomTemp = random.Next(0, temperatures.Count);
            temperature = temperatures[randomTemp];
          
        }
    }
}
