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
    string heading = "Person" + "'s Concessions";
    
    public MainViewModel() 
    {
        UserConcessions = new ObservableCollection<Concession>
        {
            new Concession { ConcessionID = 1, ConcessionType = 3, UserID = 1, DatePaid = new DateTime(2023, 8, 29), Status ="REQUESTED"},
            new Concession { ConcessionID = 2, ConcessionType = 7, UserID = 1, DatePaid = new DateTime(2023, 8, 23), Status ="PAID"}
        };
    }

    // Navigation Command
    [RelayCommand]
    async Task Navigate()
    {
        await Shell.Current.GoToAsync(nameof(BuyConcessionsPage));
    }
}
