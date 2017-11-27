using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Weather
    {
        private int tempurature;
        private string weather;
        private Random randomSeed = new Random();
        public Weather()
        {
            tempurature = generateTempurature();
            weather = generateWeather();
        }

        public int generateTempurature()
        {
            return randomSeed.Next(32, 100);
        }

        public string generateWeather()
        {
            int weatherSeed = randomSeed.Next(1, 3);
           
            if (weatherSeed == 1)
            {
                return "sunny";
            }
            else if(weatherSeed == 2)
            {
                return "rainy";
            }
            else
            {
                return "cloudy";
            }
        }
        public string GetWeather()
        {
            return weather;
        }

        public int getTempurature()
        {
            return tempurature;
        }
        
    }
}
