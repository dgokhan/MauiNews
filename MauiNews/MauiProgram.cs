using MauiNews.ViewModel;
using MauiNews.Views;

namespace MauiNews;

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
				fonts.AddFont("Poppins-Black.ttf", "PoppinsBlack");
				fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
				fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
				fonts.AddFont("Poppins-Thin.ttf", "PoppinsThin");
                fonts.AddFont("materialdesignicons-webfont.ttf", "IconFont");
            });

        builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);
        builder.Services.AddSingleton<IMap>(Map.Default);

        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddTransient<NewsDetailViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<NewsDetailPage>();

        return builder.Build();
	}
}
