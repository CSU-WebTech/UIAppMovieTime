using System.Text.Json.Serialization;

namespace MovieTime.Models;

public record SearchMovieResponse{
        [JsonPropertyName("Title")]
        public string title {get; init;}

        [JsonPropertyName("Released")]
        public string date {get; init;}
        
        [JsonPropertyName("Plot")]
        public string explanation {get; init;}

        [JsonPropertyName("Poster")]
        public string url {get; init;}

        [JsonPropertyName("Director")]
        public string director{get; set;}

        [JsonPropertyName("Actors")]
        public string actors{get; set;}

        
        
        
}