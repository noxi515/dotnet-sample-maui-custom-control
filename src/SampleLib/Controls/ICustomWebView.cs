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
}