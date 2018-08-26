using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Steam.Models.News {

    /// <summary>
    /// Class representing a list of news items as returned by the Steam Web API.
    /// </summary>
    public class SteamNewsList : SteamObject {

        #region Properties

        /// <summary>
        /// Gets the ID of the parent app (game).
        /// </summary>
        public int AppId { get; }

        /// <summary>
        /// Gets an array of the news items returned in the response.
        /// </summary>
        public SteamNewsItem[] Items { get; }

        /// <summary>
        /// Gets the total amount of news items of the parent app.
        /// </summary>
        public int Count { get; }

        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamNewsList(JObject obj) : base(obj) {
            AppId = obj.GetInt32("appid");
            Items = obj.GetArrayItems("newsitems", SteamNewsItem.Parse);
            Count = obj.GetInt32("count");
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="SteamNewsList"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamNewsList"/>.</returns>
        public static SteamNewsList Parse(JObject obj) {
            return obj == null ? null : new SteamNewsList(obj);
        }

        #endregion

    }

}