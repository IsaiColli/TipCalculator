using TipCalculadora.Maui.ViewModels;

namespace TipCalculadora.Maui.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}