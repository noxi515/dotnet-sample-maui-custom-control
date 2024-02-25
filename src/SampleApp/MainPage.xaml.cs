using System.Diagnostics;

namespace SampleApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnClickGoBack(object? sender, EventArgs e)
    {
        WebView.GoBack();
    }

    private void OnClickGoForward(object? sender, EventArgs e)
    {
        WebView.GoForward();
    }

    private void OnClickReload(object? sender, EventArgs e)
    {
        WebView.Reload();
    }

    private void OnNavigationEnd(object? sender, EventArgs e)
    {
        Debug.WriteLine("NavigationEnd");
    }
}

