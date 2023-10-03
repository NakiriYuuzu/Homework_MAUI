using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Week04;

public partial class Week04 : ContentPage
{
    public Week04()
    {
        InitializeComponent();
    }

    private void Frame_Tapped(object sender, TappedEventArgs e)
    {
        var parameter = e.Parameter as string;
        Navigation.PushAsync(new Week04Detail(parameter));
    }
}