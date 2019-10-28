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

        //constructor

        public Weather()
        {
            weatherConditions = new List<string>(){"rainy", "overcast", "sunny", "thunderstorm", "partly cloudy"};
        }


        //member methods
        public string GenerateWeather()
        {

        }
    }
}
