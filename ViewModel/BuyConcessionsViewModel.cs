using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ZumbaMobileApp.ViewModel;

public partial class BuyConcessionsViewModel : ObservableObject
{
    [ObservableProperty]
    string name = "Person";
    
    [ObservableProperty]
    Dictionary<int, string> concessions;

    public BuyConcessionsViewModel()
    {
        Concessions = new Dictionary<int, string>();
        concessions.Add(1, "Single Concession");
        concessions.Add(3, "Basic Concessions");
        concessions.Add(7, "Premium Concessions");
    }

    // Navigation Command
    [RelayCommand]
    async Task Navigate()
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}
