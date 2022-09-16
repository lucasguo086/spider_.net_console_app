using System.Threading.Tasks;
namespace spider.Driver;

public class HttpClientDriver
{
    public static readonly HttpClient Client = new HttpClient();
    readonly string _url;

    public HttpClientDriver(string url)
    {
        this._url = url;
    }

    public void AddHeader(string key, string value)
    {
        Client.DefaultRequestHeaders.Add(key,value);
    }

    public async Task<string> GetPageSource()
    {
        return await ProcessRepositories();
    }

    
    public async Task<string> ProcessRepositories()
    {
        Console.WriteLine("@@@"+_url);
        HttpResponseMessage response = await Client.GetAsync(_url);
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        return responseBody;
    }
    
}