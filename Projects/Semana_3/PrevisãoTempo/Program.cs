using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Globalization;

namespace PrevisãoTempo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();

            Console.WriteLine("Cidade: ");
            string cidade = Console.ReadLine();

            string city = await client.GetStringAsync($"https://geocoding-api.open-meteo.com/v1/search?name={cidade}&count=1");
          
            var geo = JsonSerializer.Deserialize<Cidade>(city);
            var local = geo.Results[0];
            
            Console.WriteLine($"Localização: {local.Name}, {local.Country} (Lat: {local.Latitude}, Lon: {local.Longitude})");

            string lat = local.Latitude.ToString(CultureInfo.InvariantCulture);
            string lon = local.Longitude.ToString(CultureInfo.InvariantCulture);


            string Temperatura = await client.GetStringAsync($"https://api.open-meteo.com/v1/forecast?latitude={lat}&longitude={lon}&current=temperature_2m");
            
            var weather = JsonSerializer.Deserialize<Temperatura>(Temperatura);
                
            Console.WriteLine($"Temperatura atual: {weather.Current.Temp}°C");
        }
    }
}