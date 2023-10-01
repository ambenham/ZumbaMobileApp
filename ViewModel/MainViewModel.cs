using CommunityToolkit.Mvvm.ComponentModel; // this does a lot of data binding etc automatically
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using ZumbaMobileApp.Models;

namespace ZumbaMobileApp.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<Concession> userConcessions;

    [ObservableProperty]
    string heading;

    User currentUser = new User(1, "John", "Doe", "john@example.com", "password1", "123 Main St", "1234567890", 30, "Male", new DateTime(2023, 8, 20));
    
    public MainViewModel() 
    {
        UserConcessions = new ObservableCollection<Concession>
        {
            new Concession(1, 3, 3, 1, new DateTime(2023, 8, 29), "REQUESTED"),
            new Concession(2, 7, 5, 1, new DateTime(2023, 8, 23), "PAID")
        };
        if (currentUser.FirstName == null)
        {
            heading = "Person" + "'s Concessions";
        }
        else
        {
            heading = currentUser.FirstName + "'s Concessions";
        }
    }

    // Navigation Command
    [RelayCommand]
    async Task Navigate()
    {
        await Shell.Current.GoToAsync(nameof(BuyConcessionsPage));
    }

    // Navigate Back Command
    [RelayCommand]
    async Task GoBack()
    {
        //await Shell.Current.GoToAsync(".."); // navigate back
        await Shell.Current.GoToAsync(nameof(BuyConcessionsPage)); // only while this is the main page
    }

}
