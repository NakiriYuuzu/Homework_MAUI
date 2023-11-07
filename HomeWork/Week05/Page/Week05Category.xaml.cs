namespace HomeWork.Week05.Page;

public partial class Week05Category : ContentPage
{
    public Week05Category(string category)
    {
        InitializeComponent();
        BindingContext = new Week05CategoryViewModel(category);
    }
    
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await ((Week05CategoryViewModel)BindingContext).LoadCommand.ExecuteAsync(0);
    }

    private async void Detail_OnClicked(object sender, EventArgs e)
    {
        var tapGestureRecognizer = (TapGestureRecognizer)((Frame)sender).GestureRecognizers.FirstOrDefault();
        if (tapGestureRecognizer is { CommandParameter: Article article })
        {
            var detailPage = new Week05Detail(article);
            await Navigation.PushAsync(detailPage);
        }
    }
}