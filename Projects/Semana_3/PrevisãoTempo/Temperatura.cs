using System;
using System.Text.Json.Serialization;
using System.Net.Http;
namespace PrevisãoTempo
{
    public class Temperatura
    {
        [JsonPropertyName("current")]
        public Current Current { get; set; }
    }
    
    public class Current
    {
        [JsonPropertyName("time")]
        public string? Time { get; set; }           

        [JsonPropertyName("interval")]
        public int Interval { get; set; }

        [JsonPropertyName("temperature_2m")]
        public double Temp { get; set; }
    }
    
}   