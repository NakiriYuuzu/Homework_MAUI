using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace HomeWork.Week05;

public class Week05CategoryViewModel
{
    public string Title { get; set; }
    private readonly string _category;
    private bool _isInitialized;
    private readonly NewsApiServices _apiServices;
    public AsyncRelayCommand LoadCommand { get; }
    public ObservableCollection<Article> Articles { get; set; } = new();
    
    public Week05CategoryViewModel(string category)
    {
        Title = category;
        _category = category;
        _apiServices = ServiceHelper.GetService<NewsApiServices>();
        LoadCommand = new AsyncRelayCommand(InitializeAsync);
    }
    
    private async Task InitializeAsync()
    {
        Console.WriteLine("LOADING INIT DATA");
        if (!_isInitialized)
        {
            await LoadInitData();
            _isInitialized = true;
        }
    }

    private async Task LoadInitData()
    {
        try
        {
            var newsResponse = await _apiServices.GetNews(categoryNames: _category);
            if (newsResponse?.Articles != null)
            {
                foreach (var article in newsResponse.Articles)
                {
                    Articles.Add(article);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading initial data: {ex.Message}");
        }
    }
}