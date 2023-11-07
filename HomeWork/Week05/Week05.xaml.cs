using HomeWork.Week05.Page;

namespace HomeWork.Week05;

public partial class Week05 : ContentPage
{
    public Week05()
    {
        InitializeComponent();
        BindingContext = new Week05ViewModel();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await ((Week05ViewModel)BindingContext).LoadCommand.ExecuteAsync(0);
    }

    private void TapGestureRecognizer_OnTapped(object sender, TappedEventArgs e)
    {
        var parameter = e.Parameter as string;
        Navigation.PushAsync(new Week05Category(parameter));
    }

    private async void OnDetail_Clicked(object sender, TappedEventArgs e)
    {
        var tapGestureRecognizer = (TapGestureRecognizer)((Frame)sender).GestureRecognizers.FirstOrDefault();
        if (tapGestureRecognizer is { CommandParameter: Article article })
        {
            var detailPage = new Week05Detail(article);
            await Navigation.PushAsync(detailPage);
        }
    }
}