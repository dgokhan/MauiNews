using MauiNews.Views;

namespace MauiNews;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(NewsDetailPage), typeof(NewsDetailPage));
	}
}
