using System.Net.Http.Json;
using MovieTime.Models;

namespace MovieTime.Clients;
public class NasaClient{

    private readonly HttpClient _client;
    public NasaClient(HttpClient client){
        _client=client;
    }
public async Task<NasaResponse> GetNasa(string date){
    var url = "https://www.omdbapi.com/?apikey=6a1d867b";

if(date != null){
 url += "&t=" + date;
}
    return await _client.GetFromJsonAsync<NasaResponse>(url);
}
}