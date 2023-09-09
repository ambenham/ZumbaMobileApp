using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ZumbaMobileApp.ViewModel;

public partial class BuyConcessionsViewModel : ObservableObject
{
    [RelayCommand]
    async Task Navigate()
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}
