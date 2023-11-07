using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HomeWork.Week05;

public partial class Week05ViewModel : ObservableObject
{
    private bool _isInitialized = false;
    public AsyncRelayCommand LoadCommand { get; }
    public ObservableCollection<Article> Articles { get; set; } = new();
    public ObservableCollection<Categories> Categories { get; set; } = new()
    {
        new Categories("world", "world"),
        new Categories("nation", "nation"),
        new Categories("business", "business"),
        new Categories("technology", "technology"),
        new Categories("entertainment", "entertainment"),
        new Categories("sports", "sports"),
        new Categories("science", "science"),
        new Categories("health", "health")
    };

    private readonly NewsApiServices _apiServices;

    public Week05ViewModel()
    {
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
            var newsResponse = await _apiServices.GetNews();
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