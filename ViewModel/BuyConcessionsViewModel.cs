using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using ZumbaMobileApp.Models;

namespace ZumbaMobileApp.ViewModel;

public partial class BuyConcessionsViewModel : ObservableObject
{
    [ObservableProperty]
    string name;
    User currentUser = new User(1, "John", "Doe", "john@example.com", "password1", "123 Main St", "1234567890", 30, "Male", new DateTime(2023, 8, 20));

    [ObservableProperty]
    Dictionary<int, string> concessions;

    public BuyConcessionsViewModel()
    {
        Concessions = new Dictionary<int, string>();
        concessions.Add(1, "Single Concession");
        concessions.Add(3, "Basic Concessions");
        concessions.Add(7, "Premium Concessions");

        if (currentUser.FirstName == null)
        {
            name = "Person";
        }
        else
        {
            name = currentUser.FirstName;
        }
    }

    // Navigation Command
    [RelayCommand]
    async Task Navigate()
    {
        await Shell.Current.GoToAsync("///MainPage");
    }
}
