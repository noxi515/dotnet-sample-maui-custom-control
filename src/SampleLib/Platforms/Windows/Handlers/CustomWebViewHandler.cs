using Microsoft.Maui.Handlers;
using SampleLib.Controls;

namespace SampleLib.Handlers;

/// <summary>
/// Windows環境でCustomWebViewの仮想コントロールとネイティブコントロールとを紐付けるハンドラー
/// </summary>
public partial class CustomWebViewHandler : ViewHandler<CustomWebView, PlatformCustomWebView>
{
    protected override PlatformCustomWebView CreatePlatformView()
    {
        // ネイティブコントロールのインスタンスを作成する
        return new PlatformCustomWebView(this.VirtualView);
    }

    protected override void ConnectHandler(PlatformCustomWebView platformView)
    {
        base.ConnectHandler(platformView);

        // ネイティブコントロールのセットアップ処理を行う
    }

    protected override void DisconnectHandler(PlatformCustomWebView platformView)
    {
        base.DisconnectHandler(platformView);

        // ネイティブコントロールのクリーンアップ処理を行う
    }

    /// <summary>
    /// URLプロパティを処理します。
    /// </summary>
    public static void MapUrl(CustomWebViewHandler handler, CustomWebView view)
    {
        if (view.Url != null)
        {
            handler.PlatformView.Source = new Uri(view.Url);
        }
    }
}