using System;
using Newtonsoft.Json.Linq;
using WeatherMap;

Console.WriteLine("Please enter your City Name.");
string cityName = Console.ReadLine();
Console.WriteLine();

var apiKeyResponse = File.ReadAllText("appsettings.json");
string key = JObject.Parse(apiKeyResponse).GetValue("weatherkey").ToString();

var client = new HttpClient();
var request = new WeatherRequest(client);

var weatherurl = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={key}&units=imperial";
Console.Write($"The temparature in {cityName} is ");
request.WeatherID(weatherurl);
Console.Write(" degrees.");
Console.WriteLine();
