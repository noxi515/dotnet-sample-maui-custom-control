using UIKit;

namespace SampleLib.Controls;

/// <summary>
/// Windows環境でCustomWebViewをレンダリングするコントロール
/// </summary>
public class PlatformCustomWebView : UIView
{
    private readonly CustomWebView _virtualView;

    public PlatformCustomWebView(CustomWebView virtualView)
    {
        this._virtualView = virtualView;
    }
}