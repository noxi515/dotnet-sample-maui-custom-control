using Microsoft.UI.Xaml.Controls;

namespace SampleLib.Controls;

/// <summary>
/// Windows環境でCustomWebViewをレンダリングするコントロール
/// </summary>
public class PlatformCustomWebView : WebView2
{
    private readonly CustomWebView _virtualView;

    public PlatformCustomWebView(CustomWebView virtualView)
    {
        this._virtualView = virtualView;
    }
}