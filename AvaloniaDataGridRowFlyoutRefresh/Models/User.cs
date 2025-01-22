using System.Collections.Generic;
using System.Diagnostics;

namespace AvaloniaDataGridRowFlyoutRefresh.Models;

public class User
{
    public string Name { get; set; } = "";
    public string FullName { get; set; } = "";
    public List<Link> UserLinks { get; set; } = [];


    public void OpenMyMainUrl()
    {
        Debug.WriteLine("OpenMyMainUrl");
    }

}
