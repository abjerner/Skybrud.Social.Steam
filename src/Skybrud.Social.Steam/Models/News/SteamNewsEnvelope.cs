using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Steam.Models.News {

    /// <summary>
    /// Class representing the response body (envelope) of a request to get news of a Steam app (game).
    /// </summary>
    public class SteamNewsEnvelope : SteamObject {

        #region Properties

        /// <summary>
        /// Gets the news list of the response.
        /// </summary>
        public SteamNewsList AppNews { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance based on the specified <paramref name="obj"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        protected SteamNewsEnvelope(JObject obj) : base(obj) {
            AppNews = obj.GetObject("appnews", SteamNewsList.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <paramref name="obj"/> into an instance of <see cref="SteamNewsList"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamNewsList"/>.</returns>
        public static SteamNewsEnvelope Parse(JObject obj) {
            return obj == null ? null : new SteamNewsEnvelope(obj);
        }

        #endregion

    }

}