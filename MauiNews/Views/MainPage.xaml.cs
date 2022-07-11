using MauiNews.ViewModel;

namespace MauiNews.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = new MainViewModel();
    }
}

