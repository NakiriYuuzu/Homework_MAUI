using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.ViewModels;

namespace HomeWork;

public partial class Week3 : ContentPage
{
    public Week3(string name)
    {
        InitializeComponent();
        BindingContext = new Week3ViewModel();
        ShowName.Text = name;
    }

    private void OnTapGestureRecognizerTapped(object sender, TappedEventArgs tappedEventArgs)
    {
        Navigation.PopAsync();
    }
}