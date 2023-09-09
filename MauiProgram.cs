using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using ZumbaMobileApp.ViewModel;

namespace ZumbaMobileApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit() // Initialize the .NET MAUI Community Toolkit
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Inter-Regular.ttf", "InterRegular");
                    fonts.AddFont("Inter-Bold.ttf", "InterBold");
                });

            
            builder.Services.AddSingleton<MainPage>(); // AddSingleton creates one MainPage and calls that every time
            builder.Services.AddSingleton<MainViewModel>();
            
            builder.Services.AddTransient<BuyConcessionsPage>(); // AddTransient creates a new BuyConcessionsPage every time & destroys it
            builder.Services.AddTransient<BuyConcessionsViewModel>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}