using CommunityToolkit.Mvvm.ComponentModel;

namespace HomeWork.Week05;

public class Week05DetailViewModel: ObservableObject
{
    public Article Article { get; set; }
    public Week05DetailViewModel(Article article)
    {
        Article = article;
    }
}