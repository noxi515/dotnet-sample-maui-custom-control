﻿using CoreGraphics;
using Foundation;
using Microsoft.Maui.Handlers;
using SampleLib.Controls;
using WebKit;

namespace SampleLib.Handlers;

/// <summary>
/// Mac環境でCustomWebViewの仮想コントロールとネイティブコントロールとを紐付けるハンドラー
/// </summary>
public partial class CustomWebViewHandler : ViewHandler<CustomWebView, PlatformCustomWebView>
{
    protected override PlatformCustomWebView CreatePlatformView()
    {
        // ネイティブコントロールのインスタンスを作成する
        return new PlatformCustomWebView(CGRect.Empty, new WKWebViewConfiguration(), this.VirtualView);
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
            handler.PlatformView.LoadRequest(new NSUrlRequest(NSUrl.FromString(view.Url)!));
        }
    }

    /// <summary>
    /// 前のページに戻るコマンドを処理します。
    /// </summary>
    public static void MapGoBackRequested(CustomWebViewHandler handler, CustomWebView view, object? args)
    {
        handler.PlatformView.GoBack();
    }

    /// <summary>
    /// 前のページに戻るコマンドを処理します。
    /// </summary>
    public static void MapGoForwardRequested(CustomWebViewHandler handler, CustomWebView view, object? args)
    {
        handler.PlatformView.GoForward();
    }

    /// <summary>
    /// ページの再読み込みコマンドを処理します。
    /// </summary>
    public static void MapReloadRequested(CustomWebViewHandler handler, CustomWebView view, object? args)
    {
        handler.PlatformView.Reload();
    }
}