using System;
using System.Text.Json.Serialization;
using System.Net.Http;

namespace PrevisãoTempo
{
    public class Cidade
    {
        [JsonPropertyName("results")]
        public List<Localidade> Results { get; set; }
    }

    public class Localidade
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }
    }
}