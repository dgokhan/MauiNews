using CommunityToolkit.Mvvm.Input;
using MauiNews.Model;
using MauiNews.Views;
using System.Collections.ObjectModel;

namespace MauiNews.ViewModel
{
    public partial class MainViewModel : BaseViewModel
    {
        public Command NewsDetailCommand { get; }
        public ObservableCollection<TrendingCollectionModel> Trends { get; set; }

        public ObservableCollection<NewsModel> News { get; set; } 
        public MainViewModel()
        {
            GetEditorsRecommendations();
            GetTrends();
        }
        
        private void GetEditorsRecommendations()
        {
            News = new ObservableCollection<NewsModel>()
            {
                new NewsModel
                {
                    Id = 1,
                     CategoryName = "Technology",
                      DateTime = DateTime.Now,
                       NewsHeadline = "Tesla is building a humanoid robot for 'boring, repetitive and dangerous' work",
                        NewSource = "FUNNEWS",
                         ViewsCount = 6123,
                          Writer = "Gökhan DOĞRU",
                           Image = GenerateRandomPic("275/150"),
                            NewsDetail = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur tempus lacus in quam laoreet, eget finibus orci pharetra. Sed molestie leo eget urna egestas tristique. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec nec luctus tortor, at sagittis orci. Integer aliquam congue nulla nec ultricies. Duis magna velit, pharetra sed maximus vitae, porta eget risus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Pellentesque a elementum quam. Integer venenatis lectus sit amet libero consequat vehicula. Maecenas hendrerit bibendum felis, nec ultrices urna rutrum non.\n\nNunc auctor sem a eros suscipit, sed euismod dui porta. Morbi convallis commodo lorem, quis congue nisl mattis non.\n\nSed viverra, elit egestas pellentesque aliquet, ligula purus interdum erat, non venenatis nisl tellus quis enim. Donec et magna a tellus accumsan malesuada et sed ex. Fusce dignissim sodales nibh posuere imperdiet. In ante sem, vehicula eu neque sed, finibus dapibus sapien. Fusce sapien ante, molestie vitae ultrices eu, semper a arcu. Curabitur molestie enim massa. Maecenas nibh mauris, porttitor in iaculis auctor, volutpat id erat."
                },
                new NewsModel
                {
                    Id = 2,
                     CategoryName = "Politics",
                      DateTime = DateTime.Now,
                       NewsHeadline = "CARE Condemns Council's Failure to Renew Syria Cross Border Resolution",
                        NewSource = "FUNNEWS",
                         ViewsCount = 4274,
                          Writer = "Doğan Oğuz",
                           Image = GenerateRandomPic("275/150"),
                            NewsDetail = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur tempus lacus in quam laoreet, eget finibus orci pharetra. Sed molestie leo eget urna egestas tristique. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec nec luctus tortor, at sagittis orci. Integer aliquam congue nulla nec ultricies. Duis magna velit, pharetra sed maximus vitae, porta eget risus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Pellentesque a elementum quam. Integer venenatis lectus sit amet libero consequat vehicula. Maecenas hendrerit bibendum felis, nec ultrices urna rutrum non.\n\nNunc auctor sem a eros suscipit, sed euismod dui porta. Morbi convallis commodo lorem, quis congue nisl mattis non.\n\nSed viverra, elit egestas pellentesque aliquet, ligula purus interdum erat, non venenatis nisl tellus quis enim. Donec et magna a tellus accumsan malesuada et sed ex. Fusce dignissim sodales nibh posuere imperdiet. In ante sem, vehicula eu neque sed, finibus dapibus sapien. Fusce sapien ante, molestie vitae ultrices eu, semper a arcu. Curabitur molestie enim massa. Maecenas nibh mauris, porttitor in iaculis auctor, volutpat id erat."
                },
                new NewsModel
                {
                    Id = 3,
                     CategoryName = "Politics",
                      DateTime = DateTime.Now,
                       NewsHeadline = "RAF fighter aircraft deploy to Finland and Sweden for joint training",
                        NewSource = "GOV.UK",
                         ViewsCount = 5789,
                          Writer = "Doğan Oğuz",
                           Image = GenerateRandomPic("275/150"),
                            NewsDetail = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur tempus lacus in quam laoreet, eget finibus orci pharetra. Sed molestie leo eget urna egestas tristique. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Donec nec luctus tortor, at sagittis orci. Integer aliquam congue nulla nec ultricies. Duis magna velit, pharetra sed maximus vitae, porta eget risus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Pellentesque a elementum quam. Integer venenatis lectus sit amet libero consequat vehicula. Maecenas hendrerit bibendum felis, nec ultrices urna rutrum non.\n\nNunc auctor sem a eros suscipit, sed euismod dui porta. Morbi convallis commodo lorem, quis congue nisl mattis non.\n\nSed viverra, elit egestas pellentesque aliquet, ligula purus interdum erat, non venenatis nisl tellus quis enim. Donec et magna a tellus accumsan malesuada et sed ex. Fusce dignissim sodales nibh posuere imperdiet. In ante sem, vehicula eu neque sed, finibus dapibus sapien. Fusce sapien ante, molestie vitae ultrices eu, semper a arcu. Curabitur molestie enim massa. Maecenas nibh mauris, porttitor in iaculis auctor, volutpat id erat."
                }
            };
        }
        private void GetTrends()
        {
            Trends = new ObservableCollection<TrendingCollectionModel>()
            {
                new TrendingCollectionModel
                {
                    Id = 1,
                        Image = GenerateRandomPic("175/250")
                },
                new TrendingCollectionModel
                {
                    Id = 2,
                        Image = GenerateRandomPic("175/250")
                },
                new TrendingCollectionModel
                {
                    Id = 3,
                        Image = GenerateRandomPic("175/250")
                }
            };
        }
        private string GenerateRandomPic(string pixel)
        {
            return $"https://picsum.photos/{pixel}";
        }

        [RelayCommand]
        private async Task GoToDetails(NewsModel m)
        {
            if (m == null)
                return;

            await Shell.Current.GoToAsync(nameof(NewsDetailPage), true, new Dictionary<string, object>
            {
                {"NewsDetail", m }
            });
        }
    }
}
