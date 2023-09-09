using ZumbaMobileApp.ViewModel;

namespace ZumbaMobileApp;

public partial class BuyConcessionsPage : ContentPage
{
	public BuyConcessionsPage(BuyConcessionsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}