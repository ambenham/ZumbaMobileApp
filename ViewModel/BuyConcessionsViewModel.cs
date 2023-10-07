using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using ZumbaMobileApp.Models;

namespace ZumbaMobileApp.ViewModel;

public partial class BuyConcessionsViewModel : ObservableObject
{
    [ObservableProperty]
    string name;
    User currentUser;

    [ObservableProperty]
    ObservableCollection<Concession> basicConcessions;

    public BuyConcessionsViewModel()
    {
        currentUser = new User(1, "John", "Doe", "john@example.com", "password1", "123 Main St", "1234567890", 30, "Male", new DateTime(2023, 8, 20));
        BasicConcessions = new ObservableCollection<Concession>
        {
            new Concession(1, "Single Concession", 1, 1, currentUser.UserID, "Buy"),
            new Concession(2, "Basic Concession", 3, 3, currentUser.UserID, "Buy"),
            new Concession(3, "Premium Concession", 7, 7, currentUser.UserID, "Buy")
        };

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

    // Navigate Back Command
    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}
