using Microsoft.Maui.Handlers;
using SampleLib.Controls;

namespace SampleLib.Handlers;

/// <summary>
/// CustomWebViewの仮想コントロールとネイティブコントロールとを紐付けるハンドラー
/// </summary>
public partial class CustomWebViewHandler
{
    /// <summary>
    /// プロパティのマッピング
    /// </summary>
    public static readonly PropertyMapper<CustomWebView, CustomWebViewHandler> PropertyMapper = new()
    {
        [nameof(CustomWebView.Url)] = MapUrl
    };

    /// <summary>
    /// コマンドのマッピング
    /// </summary>
    public static readonly CommandMapper<CustomWebView, CustomWebViewHandler> CommandMapper = new(ViewHandler.ViewCommandMapper);

    public CustomWebViewHandler()
        : base(PropertyMapper, CommandMapper)
    {
    }
}