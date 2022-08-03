using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WeatherMap
{
    public class WeatherRequest
    {
        private HttpClient _client;
        public WeatherRequest(HttpClient client)
        {
            _client = client;
        }

        public void WeatherID(string weatherurl)
        {
            var weatherClient = _client.GetStringAsync(weatherurl).Result;
            var weather = JObject.Parse(weatherClient)["main"]["temp"].ToString();
            //[].first[] sometimes works over [][]
            Console.Write(weather);
        }
        
    }
}
