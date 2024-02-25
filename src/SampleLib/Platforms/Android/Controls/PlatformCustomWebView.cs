using Android.Content;

namespace SampleLib.Controls;

/// <summary>
/// Android環境でCustomWebViewをレンダリングするコントロール
/// </summary>
public class PlatformCustomWebView : Android.Webkit.WebView
{
    private readonly CustomWebView _virtualView;

    public PlatformCustomWebView(Context context, CustomWebView virtualView)
        : base(context)
    {
        this._virtualView = virtualView;
    }
}