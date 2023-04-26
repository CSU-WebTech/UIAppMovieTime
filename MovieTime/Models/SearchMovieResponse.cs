using System.Text.Json.Serialization;

namespace MovieTime.Models;

public record SearchMovieResponse{

        [JsonPropertyName("Search")]
        public List<Searching> Search {get; init;}


public class Searching{
       
        public string Title {get; set;}

        public string Year {get; set;}
        
        public string Poster {get; set;}

        public string Type {get; set;}         
        
}

public class SearchMovieFinal{
        public List<Searching> search{get;set;}
}
}