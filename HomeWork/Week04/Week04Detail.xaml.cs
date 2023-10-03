namespace HomeWork.Week04;

public partial class Week04Detail : ContentPage
{
    public Week04Detail(string type)
    {
        InitializeComponent();
        BindingContext = new Week04DetailViewModel(type);
    }

    private void OnItemTapped(object sender, TappedEventArgs e)
    {
        var frame = sender as Frame;
        var learningItem = frame?.BindingContext as LearningItem;
        if (learningItem == null)
            return;
        Console.WriteLine(learningItem.Name);
        TextToSpeech.Default.SpeakAsync(learningItem.Name);
    }
}