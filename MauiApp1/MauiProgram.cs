﻿using MauiApp1.Data;
using MauiApp1.NewFolder;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;





namespace MauiApp1
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
        builder.Services.AddMudServices();
        builder.Services.AddSingleton<User>();
#endif

            // builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}