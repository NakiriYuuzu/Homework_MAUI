namespace HomeWork;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnButtonClicked(object sender, EventArgs args)
    {
        Navigation.PushAsync(new Week3(Input.Text));
    }
}