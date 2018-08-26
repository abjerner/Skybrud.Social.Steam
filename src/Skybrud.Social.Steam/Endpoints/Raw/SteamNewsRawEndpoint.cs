using System;
using Skybrud.Essentials.Time;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.News;
using Skybrud.Social.Steam.Options.News;

namespace Skybrud.Social.Steam.Endpoints.Raw {
    
    /// <summary>
    /// Class representing the raw implementation of the Steam news endpoint.
    /// </summary>
    public class SteamNewsRawEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamHttpClient Client { get; }

        #endregion

        #region Constructors

        internal SteamNewsRawEndpoint(SteamHttpClient client) {
            Client = client;
        }

        #endregion

        #region Member methods ethods

        /// <summary>
        /// Gets a list of news items for the app (game) matching the specified <paramref name="appId"/>.
        /// </summary>
        /// <param name="appId">The app ID.</param>
        /// <param name="maxLength">The maximum length of the <see cref="SteamNewsItem.Contents"/> field.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="count">The maximum amount of news items to be returned.</param>
        /// <param name="feeds">The name of the feeds from which news items should be returned. If not specified, news items of all feeds will be returned.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetNewsForApp(uint appId, uint maxLength = 0, EssentialsDateTime endDate = null, uint count = 0, string[] feeds = null) {
            return GetNewsForApp(new SteamGetNewsForAppOptions {
                AppId = appId,
                MaxLength = maxLength,
                EndDate = endDate,
                Count = count,
                Feeds = feeds
            });
        }

        /// <summary>
        /// Gets a list of news items for the app (game) matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="SocialHttpResponse"/> representing the raw response.</returns>
        public SocialHttpResponse GetNewsForApp(SteamGetNewsForAppOptions options) {
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamNews/GetNewsForApp/v2/", options);
        }

        #endregion

    }

}