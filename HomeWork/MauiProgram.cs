using HomeWork.Week05;
using Microsoft.Extensions.Logging;

namespace HomeWork;

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

        // Dependency Injection
        builder.Services.AddSingleton<HttpClient>();
        builder.Services.AddSingleton<NewsApiServices>();

        // Logging
        builder.Logging.AddDebug();

        // Initialize ServiceHelper
        var app = builder.Build();
        ServiceHelper.Initialize(app.Services);

        return app;
    }
}