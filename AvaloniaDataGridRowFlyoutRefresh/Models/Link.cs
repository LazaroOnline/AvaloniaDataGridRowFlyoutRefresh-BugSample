using System.Diagnostics;

namespace AvaloniaDataGridRowFlyoutRefresh.Models;

public class Link
{
    public string LinkName { get; set; }

    public void OpenUrl()
    {
        Debug.WriteLine($"OpenUrl: {LinkName}");
    }
}
