using MauiNavigationTest.Pages;
using Microsoft.Extensions.DependencyInjection;

namespace MauiNavigationTest;

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

		builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<FirstPage>();
        builder.Services.AddSingleton<SecondPage>();
        builder.Services.AddTransient<ThirdPage>();

        return builder.Build();
	}
}
