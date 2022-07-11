using CommunityToolkit.Mvvm.ComponentModel;
using MauiNews.Model;

namespace MauiNews.ViewModel
{
    [QueryProperty(nameof(NewsDetail), nameof(NewsDetail))]
    public partial class NewsDetailViewModel : BaseViewModel
    {
        [ObservableProperty]
        NewsModel newsDetail;
        
    }
}
