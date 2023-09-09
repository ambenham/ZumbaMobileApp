using CommunityToolkit.Mvvm.ComponentModel; // this does a lot of data binding etc automatically
using CommunityToolkit.Mvvm.Input;

namespace ZumbaMobileApp.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [RelayCommand]
    async Task Navigate()
    {
        await Shell.Current.GoToAsync(nameof(BuyConcessionsPage));
    }
}
