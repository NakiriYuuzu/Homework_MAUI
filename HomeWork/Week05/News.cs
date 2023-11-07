// YApi QuickType插件生成，具体参考文档:https://plugins.jetbrains.com/plugin/18847-yapi-quicktype/documentation

using Newtonsoft.Json;

namespace HomeWork.Week05
{
    public partial class News
    {
        [JsonProperty("totalArticles")]
        public long TotalArticles { get; set; }

        [JsonProperty("articles")]
        public List<Article> Articles { get; set; }
    }

    public partial class Article
    {
        [JsonProperty("image")]
        public Uri Image { get; set; }

        [JsonProperty("publishedAt")]
        public DateTimeOffset PublishedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class Source
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public class Categories
    {
        public Categories(string category, string icon)
        {
            Category = category;
            Icon = icon;
        }
        public string Category { get; set; }
        public string Icon { get; set; }
    }
}
