namespace SampleLib.Controls;

/// <summary>
/// カスタムWebViewのインターフェース
/// </summary>
public interface ICustomWebView
{
    /// <summary>
    /// 表示URL
    /// </summary>
    string? Url { get; set; }

    /// <summary>
    /// 前のページに戻ります。
    /// </summary>
    void GoBack();

    /// <summary>
    /// 次のページに進みます。
    /// </summary>
    void GoForward();

    /// <summary>
    /// ページを再読み込みします。
    /// </summary>
    void Reload();
}