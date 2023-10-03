using CommunityToolkit.Mvvm.ComponentModel;

namespace HomeWork.Week04;

public class LearningItem: ObservableObject
{
    public LearningItem(string name, string image)
    {
        Name = name;
        Image = image;
    }
    public string Name { get; set; }
    public string Image { get; set; }
}