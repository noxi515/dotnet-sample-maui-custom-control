using SampleLib.Controls;
using SampleLib.Handlers;

namespace SampleLib;

public static class MauiAppBuilderExtensions
{
    /// <summary>
    /// MAUIアプリにSampleLibsを登録します。
    /// </summary>
    public static MauiAppBuilder UseSampleLib(this MauiAppBuilder builder)
    {
        // カスタムコントロールとハンドラーの登録
        builder.ConfigureMauiHandlers(handlers =>
        {
            handlers.AddHandler<CustomWebView, CustomWebViewHandler>();
        });

        return builder;
    }

}