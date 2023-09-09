using CommunityToolkit.Mvvm.Input;

namespace ZumbaMobileApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(BuyConcessionsPage), typeof(BuyConcessionsPage));
        }
    }
}