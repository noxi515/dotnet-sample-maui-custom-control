using Microsoft.Maui.Handlers;
using SampleLib.Controls;

namespace SampleLib.Handlers;

/// <summary>
/// iOS環境でCustomWebViewの仮想コントロールとネイティブコントロールとを紐付けるハンドラー
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
}