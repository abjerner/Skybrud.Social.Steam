using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Essentials.Time;

namespace Skybrud.Social.Steam.Models.News {
    
    /// <summary>
    /// Class representing a new item as returned by the Steam Web API.
    /// </summary>
    /// <see>
    ///     <cref>https://developer.valvesoftware.com/wiki/Steam_Web_API#GetNewsForApp_.28v0002.29</cref>
    /// </see>
    public class SteamNewsItem : SteamObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the news item.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Gets the title of the news item.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Gets the URL to the news article.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Gets whether <see cref="Url"/> is an external URL.
        /// </summary>
        public bool IsExternalUrl { get; }

        /// <summary>
        /// Gets the author of the news article.
        /// </summary>
        public string Author { get; }

        /// <summary>
        /// Gets the contents of the news article.
        /// </summary>
        public string Contents { get; }

        /// <summary>
        /// Gets the feed label of the news item.
        /// </summary>
        public string FeedLabel { get; }

        /// <summary>
        /// Gets the date when the news article was released.
        /// </summary>
        public EssentialsDateTime Date { get; }

        /// <summary>
        /// Gets the feed name of the news item.
        /// </summary>
        public string FeedName { get; }

        /// <summary>
        /// Gets the feed type of the news item.
        /// </summary>
        public int FeedType { get; }

        /// <summary>
        /// Gets the ID of the parent app (game).
        /// </summary>
        public int AppId { get; }

        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamNewsItem(JObject obj) : base(obj) {
            Id = obj.GetString("id");
            Title = obj.GetString("title");
            Url = obj.GetString("url");
            IsExternalUrl = obj.GetBoolean("is_external_url");
            Author = obj.GetString("author");
            Contents = obj.GetString("contents");
            FeedLabel = obj.GetString("feedlabel");
            Date = obj.GetInt32("date", EssentialsDateTime.FromUnixTimestamp);
            FeedName = obj.GetString("feedname");
            FeedType = obj.GetInt32("feed_type");
            AppId = obj.GetInt32("appid");
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="SteamNewsItem"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamNewsItem"/>.</returns>
        public static SteamNewsItem Parse(JObject obj) {
            return obj == null ? null : new SteamNewsItem(obj);
        }

        #endregion

    }

}