using MauiApp_App.Mvvm.ViewModels;
using MauiApp_App.Mvvm.Views;
using Microsoft.Extensions.Logging;
using Shared.Services;

namespace MauiApp_App
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

            builder.Services.AddSingleton<UserService>();

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainPageViewModel>();

            builder.Services.AddSingleton<AddPage>();
            builder.Services.AddSingleton<AddPageViewModel>();

            builder.Services.AddSingleton<DetailsPage>();
            builder.Services.AddSingleton<DetailsPageViewModel>();

            builder.Services.AddSingleton<EditPage>();
            builder.Services.AddSingleton<EditPageViewModel>();

            

            return builder.Build();
        }
    }
}