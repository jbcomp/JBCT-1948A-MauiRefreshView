using Microsoft.Extensions.Logging;

namespace MauiRefreshView
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            Routing.RegisterRoute(nameof(EnabledRefreshViewPage), typeof(EnabledRefreshViewPage));
            Routing.RegisterRoute(nameof(DisabledRefreshViewPage), typeof(DisabledRefreshViewPage));
            Routing.RegisterRoute(nameof(NoRefreshViewPage), typeof(NoRefreshViewPage));

            return builder.Build();
        }
    }
}
