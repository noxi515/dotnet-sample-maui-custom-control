using System.ComponentModel;

namespace SampleLib.Controls;

/// <summary>
/// カスタムWebViewの仮想コントロール
/// </summary>
public class CustomWebView : View, ICustomWebView
{
    public static readonly BindableProperty UrlProperty = BindableProperty.Create(
        propertyName: nameof(Url),
        returnType: typeof(string),
        declaringType: typeof(CustomWebView),
        defaultValue: null
    );

    /// <summary>
    /// 表示URL
    /// </summary>
    public string? Url
    {
        get => (string?) this.GetValue(UrlProperty);
        set => this.SetValue(UrlProperty, value);
    }


    /// <summary>
    /// 前のページに戻るイベント
    /// </summary>
    public event EventHandler? GoBackRequested;

    /// <summary>
    /// 次のページに進むイベント
    /// </summary>
    public event EventHandler? GoForwardRequested;

    /// <summary>
    /// ページをリロードするイベント
    /// </summary>
    public event EventHandler? ReloadRequested;


    /// <summary>
    /// 前のページに戻ります。
    /// </summary>
    public void GoBack()
    {
        this.Handler?.Invoke(nameof(GoBackRequested), null);
        this.GoBackRequested?.Invoke(this, EventArgs.Empty);
    }

    /// <summary>
    /// 次のページに進みます。
    /// </summary>
    public void GoForward()
    {
        this.Handler?.Invoke(nameof(GoForwardRequested), null);
        this.GoForwardRequested?.Invoke(this, EventArgs.Empty);
    }

    /// <summary>
    /// ページを再読み込みします。
    /// </summary>
    public void Reload()
    {
        this.Handler?.Invoke(nameof(ReloadRequested), null);
        this.ReloadRequested?.Invoke(this, EventArgs.Empty);
    }


    /// <summary>
    /// ナビゲーションの終了イベント
    /// </summary>
    public event EventHandler? NavigationEnd;

    /// <summary>
    /// ナビゲーションの終了イベントを送信します。
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public void SendNavigationEnd()
    {
        this.NavigationEnd?.Invoke(this, EventArgs.Empty);
    }
}