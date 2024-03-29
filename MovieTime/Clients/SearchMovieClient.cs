using System.Net.Http.Json;
using MovieTime.Models;

namespace MovieTime.Clients;
public class SearchMovieClient{

    private readonly HttpClient _client;
    public SearchMovieClient(HttpClient client){
        _client=client;
    }
public async Task<SearchMovieResponse> GetMovie(string title){
    var url = "https://www.omdbapi.com/?apikey=6a1d867b";
    if(title != null){
    url += "&s=" + title;
    
    }
    else{
       url += "&s=" + "Home+Alone"; 
    }
    //public SearchMovieResponse? response=await _client.GetFromJsonAsync<SearchMovieResponse>(url);
    Console.WriteLine(url);
    return await _client.GetFromJsonAsync<SearchMovieResponse>(url);
    //return response;
    
}
}