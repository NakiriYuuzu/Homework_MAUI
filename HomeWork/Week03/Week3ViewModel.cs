using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace HomeWork.Week03;

public class Week3ViewModel: ObservableObject
{
    string[] _fruitNames = {
        "Apple", "Apricot", "Banana", "Coconut", "Grape", "Guava", "Kiwi", "Mango",
        "Melon", "Orange", "Peach", "Pear", "Pineapple", "Plum", "Pomegranate", "Strawberry", "Watermelon"
    };
    
    public ObservableCollection<Fruit> FruitsList { get; set; } = new();
    
    public Week3ViewModel()
    {
        foreach (var fruitName in _fruitNames)
        {
            var checkAnOrA = "aeiou".Contains(char.ToLower(fruitName[0])) ? "an" : "a";
            var imageName = fruitName.ToLower() + ".png";  // 假設圖片名稱是水果名稱的小寫形式
            FruitsList.Add(new Fruit(fruitName, imageName, $"This is {checkAnOrA} {fruitName}."));
        }
    }
}