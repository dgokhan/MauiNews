namespace MauiNews.Model
{
    public class NewsModel
    {
        public long Id { get; set; }
        public string Image { get; set; }
        public string CategoryName { get; set; }
        public string NewsHeadline { get; set; }
        public string NewsDetail { get; set; }
        public string NewSource { get; set; }
        public string Writer { get; set; }
        public int ViewsCount { get; set; }
        public DateTime DateTime { get; set; }
    }
}
