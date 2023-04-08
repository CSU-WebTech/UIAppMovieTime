using System.Net.Http.Json;
using MovieTime.Models;

namespace MovieTime.Clients;
public class NasaClient{

    private readonly HttpClient _client;
    public NasaClient(HttpClient client){
        _client=client;
    }
public async Task<NasaResponse> GetNasa(string date){
    var url = "https://api.nasa.gov/planetary/apod?api_key=8gWfQi3EmW5RUs3ffciAZQNhMcsVHFXXGodmIpQg";
if(date != null){
 url += "&date=" + date;
}

    return await _client.GetFromJsonAsync<NasaResponse>(url);
}
}