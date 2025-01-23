using System.Collections.ObjectModel;
using System.Diagnostics;
using ReactiveUI;
using AvaloniaDataGridRowFlyoutRefresh.Models;
using System.Linq;

namespace AvaloniaDataGridRowFlyoutRefresh.ViewModels;

public class MainViewModel : ViewModelBase
{
    public ObservableCollection<User> UserList { get; set; } = [
        new() { Name = "Peter", FullName = "Peter Parker", UserLinks = [
            new Link() { LinkName = "Peter Link 1" },
            new Link() { LinkName = "Peter Link 2" }
        ] }
    ];

    public void ChangeUsers()
    {
        UserList.Clear();
        //if (UserList.FirstOrDefault()?.Name == "Peter")
        {
            UserList.Add(new() { Name = "Bruce", FullName = "Bruce Wayne", UserLinks = [
                    new Link() { LinkName = "Bruce Link 1" }
                ]
            });
        }
    }

    public void OpenUrlVM()
    {
        Debug.WriteLine($"OpenUrl from VM");
    }

}
