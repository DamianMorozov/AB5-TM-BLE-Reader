using Ab5tmBleReader.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace Ab5tmBleReader.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
