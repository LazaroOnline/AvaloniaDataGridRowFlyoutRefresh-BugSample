using System.Diagnostics;

namespace AvaloniaDataGridRowFlyoutRefresh.Models;

public class Link
{
    public string LinkName { get; set; }
    public string Url { get; set; } = "some-url";

    public void OpenUrl()
    {
        Debug.WriteLine($"OpenUrl from Link: {LinkName}");
    }

    public void OpenUrlWithParam(string anUrl)
    {
        Debug.WriteLine($"OpenUrl from Link: {anUrl}");
    }
}
