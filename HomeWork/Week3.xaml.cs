using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork;

public partial class Week3 : ContentPage
{
    public Week3()
    {
        InitializeComponent();
    }

    private void OnTapGestureRecognizerTapped(object sender, TappedEventArgs tappedEventArgs)
    {
        Navigation.PopAsync();
    }
}