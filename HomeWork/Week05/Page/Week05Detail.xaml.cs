using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Week05.Page;

public partial class Week05Detail : ContentPage
{
    public Week05Detail(Article article)
    {
        InitializeComponent();
        BindingContext = new Week05DetailViewModel(article);
    }
}