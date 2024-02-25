using CoreGraphics;
using WebKit;

namespace SampleLib.Controls;

/// <summary>
/// Windows環境でCustomWebViewをレンダリングするコントロール
/// </summary>
public class PlatformCustomWebView : WKWebView
{
    private readonly CustomWebView _virtualView;

    public PlatformCustomWebView(CGRect frame, WKWebViewConfiguration configuration, CustomWebView virtualView)
        : base(frame, configuration)
    {
        this._virtualView = virtualView;
    }
}