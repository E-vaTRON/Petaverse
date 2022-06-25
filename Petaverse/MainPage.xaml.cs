using Petaverse.ViewModels;

namespace Petaverse;

public partial class MainPage : ContentPage
{
	public MainPage(AbstractViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

