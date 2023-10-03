using HomeWork.Week03;

namespace HomeWork;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs args)
    {
        var button = sender as Button;
        var week = button?.CommandParameter as string;

        switch (week)
        {
            case "week03":
                Navigation.PushAsync(new Week3());
                break;
            case "week04":
                Navigation.PushAsync(new Week04.Week04());
                break;
        }
    }
}