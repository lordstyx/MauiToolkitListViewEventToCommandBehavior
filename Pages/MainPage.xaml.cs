using MauiToolkitListViewEventToCommandBehavior.Models;
using MauiToolkitListViewEventToCommandBehavior.PageModels;

namespace MauiToolkitListViewEventToCommandBehavior.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}