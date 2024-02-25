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
}