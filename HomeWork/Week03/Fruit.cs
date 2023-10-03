using CommunityToolkit.Mvvm.ComponentModel;

namespace HomeWork.Week03;

public class Fruit : ObservableObject
{
    public Fruit(string name, string image, string description)
    {
        Name = name;
        Image = image;
        Description = description;
    }
    
    public string Name { get; set; }
    public string Image { get; set; }
    public string Description { get; set; }
}