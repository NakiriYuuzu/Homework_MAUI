using Newtonsoft.Json;

namespace HomeWork.Week05;

public class NewsApiServices
{
    private const string Key = "60313c06288602d6b82125569dfc995d";
    private readonly HttpClient _httpClient;

    public NewsApiServices(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
        
    public async Task<News> GetNews(string categoryNames = "general", int page = 10)
    {
        try
        {
            string url = $"https://gnews.io/api/v4/top-headlines?category={categoryNames}&lang=zh-tw&country=tw&max={page}&apikey={Key}";
            var response = await _httpClient.GetStringAsync(url);
            var news = JsonConvert.DeserializeObject<News>(response);
            Console.WriteLine("Total News: " + news.TotalArticles);
            return news;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error fetching news: {ex.Message}");
            return null;
        }
    }
}