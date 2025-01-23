using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace AvaloniaDataGridRowFlyoutRefresh.Models;

public class User
{
    public string Name { get; set; } = "";
    public string FullName { get; set; } = "";
    public ObservableCollection<Link> UserLinks { get; set; } = [];


    public void OpenMyMainUrl()
    {
        Debug.WriteLine("OpenMyMainUrl");
    }

}
