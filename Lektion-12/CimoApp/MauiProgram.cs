using CimoApp.Mvvm.ViewModels;
using CimoApp.Mvvm.Views;
using Microsoft.Extensions.Logging;

namespace CimoApp
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


            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<MainPage>();

            builder.Services.AddSingleton<DetailsViewModel>();
            builder.Services.AddSingleton<DetailsPage>();

            builder.Services.AddSingleton<EditViewModel>();
            builder.Services.AddSingleton<EditPage>();

            builder.Services.AddSingleton<AddViewModel>();
            builder.Services.AddSingleton<AddPage>();


            return builder.Build();
        }
    }
}