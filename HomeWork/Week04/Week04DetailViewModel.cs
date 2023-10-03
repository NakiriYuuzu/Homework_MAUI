using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace HomeWork.Week04;

public class Week04DetailViewModel : ObservableObject
{
    public string Title { get; set; }
    public ObservableCollection<LearningItem> LearningList { get; set; }

    public Week04DetailViewModel(string type)
    {
        Title = "Learning " + type;
        LearningList = new();
        switch (type)
        {
            case "numbers":
                LearningList.Add(new LearningItem(name: "One", image: "one.png"));
                LearningList.Add(new LearningItem(name: "Two", image: "two.png"));
                LearningList.Add(new LearningItem(name: "Three", image: "three.png"));
                LearningList.Add(new LearningItem(name: "Four", image: "four.png"));
                LearningList.Add(new LearningItem(name: "Five", image: "five.png"));
                LearningList.Add(new LearningItem(name: "Six", image: "six.png"));
                LearningList.Add(new LearningItem(name: "Seven", image: "seven.png"));
                LearningList.Add(new LearningItem(name: "Eight", image: "eight.png"));
                LearningList.Add(new LearningItem(name: "Nine", image: "nine.png"));
                LearningList.Add(new LearningItem(name: "Ten", image: "ten.png"));
                break;
            case "letters":
                LearningList.Add(new LearningItem(name: "a", image: "alphabet_a.png"));
                LearningList.Add(new LearningItem(name: "b", image: "alphabet_b.png"));
                LearningList.Add(new LearningItem(name: "c", image: "alphabet_c.png"));
                LearningList.Add(new LearningItem(name: "d", image: "alphabet_d.png"));
                LearningList.Add(new LearningItem(name: "e", image: "alphabet_e.png"));
                LearningList.Add(new LearningItem(name: "f", image: "alphabet_f.png"));
                LearningList.Add(new LearningItem(name: "g", image: "alphabet_g.png"));
                LearningList.Add(new LearningItem(name: "h", image: "alphabet_h.png"));
                LearningList.Add(new LearningItem(name: "i", image: "alphabet_i.png"));
                LearningList.Add(new LearningItem(name: "j", image: "alphabet_j.png"));
                LearningList.Add(new LearningItem(name: "k", image: "alphabet_k.png"));
                LearningList.Add(new LearningItem(name: "l", image: "alphabet_l.png"));
                LearningList.Add(new LearningItem(name: "m", image: "alphabet_m.png"));
                LearningList.Add(new LearningItem(name: "n", image: "alphabet_n.png"));
                LearningList.Add(new LearningItem(name: "o", image: "alphabet_o.png"));
                LearningList.Add(new LearningItem(name: "p", image: "alphabet_p.png"));
                LearningList.Add(new LearningItem(name: "q", image: "alphabet_q.png"));
                LearningList.Add(new LearningItem(name: "r", image: "alphabet_r.png"));
                LearningList.Add(new LearningItem(name: "s", image: "alphabet_s.png"));
                LearningList.Add(new LearningItem(name: "t", image: "alphabet_t.png"));
                LearningList.Add(new LearningItem(name: "u", image: "alphabet_u.png"));
                LearningList.Add(new LearningItem(name: "v", image: "alphabet_v.png"));
                LearningList.Add(new LearningItem(name: "w", image: "alphabet_w.png"));
                LearningList.Add(new LearningItem(name: "x", image: "alphabet_x.png"));
                LearningList.Add(new LearningItem(name: "y", image: "alphabet_y.png"));
                LearningList.Add(new LearningItem(name: "z", image: "alphabet_z.png"));
                break;
            case "shapes":
                LearningList.Add(new LearningItem(name: "Triangle", image: "triangle.png"));
                LearningList.Add(new LearningItem(name: "Circle", image: "circle.png"));
                LearningList.Add(new LearningItem(name: "Square", image: "square.png"));
                LearningList.Add(new LearningItem(name: "Rectangle", image: "rectangle.png"));
                LearningList.Add(new LearningItem(name: "Oval", image: "oval.png"));
                LearningList.Add(new LearningItem(name: "Star", image: "star.png"));
                LearningList.Add(new LearningItem(name: "Heart", image: "heart.png"));
                LearningList.Add(new LearningItem(name: "Arrow", image: "arrow.png"));
                LearningList.Add(new LearningItem(name: "Pyramid", image: "pyramid.png"));
                LearningList.Add(new LearningItem(name: "Cube", image: "cube.png"));
                break;
            case "colors":
                LearningList.Add(new LearningItem(name: "Black", image: "color_black.png"));
                LearningList.Add(new LearningItem(name: "Blue", image: "color_blue.png"));
                LearningList.Add(new LearningItem(name: "Gray", image: "color_gray.png"));
                LearningList.Add(new LearningItem(name: "Green", image: "color_green.png"));
                LearningList.Add(new LearningItem(name: "Orange", image: "color_orange.png"));
                LearningList.Add(new LearningItem(name: "Purple", image: "color_purple.png"));
                LearningList.Add(new LearningItem(name: "Red", image: "color_red.png"));
                LearningList.Add(new LearningItem(name: "Yellow", image: "color_yellow.png"));
                break;
            case "fruits":
                LearningList.Add(new LearningItem(name: "Apple", image: "apple.png"));
                LearningList.Add(new LearningItem(name: "Banana", image: "banana.png"));
                LearningList.Add(new LearningItem(name: "Orange", image: "orange.png"));
                LearningList.Add(new LearningItem(name: "Strawberry", image: "strawberry.png"));
                LearningList.Add(new LearningItem(name: "Grape", image: "grape.png"));
                LearningList.Add(new LearningItem(name: "Lemon", image: "lemon.png"));
                LearningList.Add(new LearningItem(name: "Watermelon", image: "watermelon.png"));
                LearningList.Add(new LearningItem(name: "Mango", image: "mango.png"));
                LearningList.Add(new LearningItem(name: "Cherry", image: "cherry.png"));
                LearningList.Add(new LearningItem(name: "Pineapple", image: "pineapple.png"));
                break;
            case "animals":
                LearningList.Add(new LearningItem(name: "Lion", image: "lion.png"));
                LearningList.Add(new LearningItem(name: "Tiger", image: "tiger.png"));
                LearningList.Add(new LearningItem(name: "Elephant", image: "elephant.png"));
                LearningList.Add(new LearningItem(name: "Dog", image: "dog.png"));
                LearningList.Add(new LearningItem(name: "Cat", image: "cat.png"));
                LearningList.Add(new LearningItem(name: "Fox", image: "fox.png"));
                LearningList.Add(new LearningItem(name: "Fish", image: "fish.png"));
                LearningList.Add(new LearningItem(name: "Bird", image: "bird.png"));
                LearningList.Add(new LearningItem(name: "Penguin", image: "penguin.png"));
                LearningList.Add(new LearningItem(name: "Bear", image: "bear.png"));
                break;
        }
    }
}