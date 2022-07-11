using MauiNews.ViewModel;

namespace MauiNews.Views;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage(NewsDetailViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
    }

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);
	}
}