using SimeHome.ViewModels;

namespace SimeHome.Views;

public partial class HomeView : ContentPage
{
	public HomeView()
	{
		InitializeComponent();
		BindingContext = new HomeViewModel();
	}
}