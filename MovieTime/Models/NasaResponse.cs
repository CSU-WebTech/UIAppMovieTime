using System.Text.Json.Serialization;

namespace MovieTime.Models;

public record NasaResponse{
        [JsonPropertyName("Title")]
        public string title {get; init;}

        [JsonPropertyName("Year")]
        public string date {get; init;}
        
        [JsonPropertyName("Plot")]
        public string explanation {get; init;}
        
        [JsonPropertyName("hdurl")]
        public string hdurl {get; init;}

        [JsonPropertyName("Poster")]
        public string url {get; init;}
        
        [JsonPropertyName("media_type")]
        public string mediaType {get; init;}
        
        [JsonPropertyName("service_version")]
        public string serviceVersion {get; init;}
        
        [JsonPropertyName("copyright")]
        public string copyright {get; init;}
}

