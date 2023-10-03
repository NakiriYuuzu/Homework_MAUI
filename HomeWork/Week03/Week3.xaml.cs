namespace HomeWork.Week03;

public partial class Week3 : ContentPage
{
    public Week3()
    {
        InitializeComponent();
        BindingContext = new Week3ViewModel();
    }

    private void OnTapGestureRecognizerTapped(object sender, TappedEventArgs tappedEventArgs)
    {
        Navigation.PopAsync();
    }

    private void OnItemTapped(object sender, TappedEventArgs e)
    {
        var frame = sender as Frame;
        var fruit = frame?.BindingContext as Fruit;
        Navigation.PushAsync(new Week03Detail(fruit));
    }
}