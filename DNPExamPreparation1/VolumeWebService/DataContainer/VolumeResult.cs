using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApplicationTEST.DataContainer
{
    public class VolumeResult
    {
        [JsonPropertyName("Id")]
        public long Id { get; set; }
        
        [JsonPropertyName("Type")] public string Type { get; set; }
        [JsonPropertyName("Height")] public double Height { get; set; }
        [JsonPropertyName("Radius")] public double Radius { get; set; }
        [JsonPropertyName("Volume")] public double Volume { get; set; }
    }
}