﻿using Microsoft.Maui.Handlers;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Web.WebView2.Core;
using SampleLib.Controls;

namespace SampleLib.Handlers;

/// <summary>
/// Windows環境でCustomWebViewの仮想コントロールとネイティブコントロールとを紐付けるハンドラー
/// </summary>
public partial class CustomWebViewHandler : ViewHandler<CustomWebView, PlatformCustomWebView>
{
    private WebView2? _webView;

    protected override PlatformCustomWebView CreatePlatformView()
    {
        // ネイティブコントロールのインスタンスを作成する
        return new PlatformCustomWebView(this.VirtualView);
    }

    protected override void ConnectHandler(PlatformCustomWebView platformView)
    {
        base.ConnectHandler(platformView);

        // ネイティブコントロールのセットアップ処理を行う
        platformView.CoreWebView2Initialized += OnCoreWebView2Initialized;
    }

    protected override void DisconnectHandler(PlatformCustomWebView platformView)
    {
        base.DisconnectHandler(platformView);

        // ネイティブコントロールのクリーンアップ処理を行う
        platformView.CoreWebView2Initialized -= OnCoreWebView2Initialized;
        if (_webView != null)
        {
            _webView.NavigationCompleted -= OnWebView2NavigationCompleted;
            _webView = null;
        }
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

    /// <summary>
    /// CoreWebView2の初期化済イベントハンドリング
    /// </summary>
    private void OnCoreWebView2Initialized(WebView2 sender, CoreWebView2InitializedEventArgs args)
    {
        _webView = sender;
        sender.NavigationCompleted += OnWebView2NavigationCompleted;
    }

    /// <summary>
    /// CoreWebView2のナビゲーション完了イベントハンドリング
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    private void OnWebView2NavigationCompleted(WebView2 sender, CoreWebView2NavigationCompletedEventArgs args)
    {
        this.VirtualView.SendNavigationEnd();
    }
}