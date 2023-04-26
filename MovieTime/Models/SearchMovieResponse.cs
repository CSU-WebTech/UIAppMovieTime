using System.Text.Json.Serialization;

namespace MovieTime.Models;

public record SearchMovieResponse{

        [JsonPropertyName("Search")]
        public List<Searching> Search {get; init;}


public class Searching{
       // [JsonPropertyName("Title")]
        public string Title {get; set;}

       // [JsonPropertyName("Released")]
        public string Year {get; set;}
        
       // [JsonPropertyName("Plot")]
      //  public string explanation {get; init;}

       // [JsonPropertyName("Poster")]
        public string Poster {get; set;}

       // [JsonPropertyName("Director")]
       // public string director{get; set;}

       // [JsonPropertyName("Actors")]
       // public string actors{get; set;}      
        
}

public class SearchMovieFinal{
        public List<Searching> search{get;set;}
}
}