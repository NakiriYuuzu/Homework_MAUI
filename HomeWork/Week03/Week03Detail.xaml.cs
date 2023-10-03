namespace HomeWork.Week03;

public partial class Week03Detail : ContentPage
{
    public Week03Detail(Fruit fruit)
    {
        InitializeComponent();
        Title.Text = fruit.Name;
        Image.Source = fruit.Image;
        Description.Text = fruit.Description;
    }
}