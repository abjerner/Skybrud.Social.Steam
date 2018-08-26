using Skybrud.Essentials.Time;
using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Models.News;
using Skybrud.Social.Steam.Options.News;
using Skybrud.Social.Steam.Responses.News;

namespace Skybrud.Social.Steam.Endpoints {
    
    /// <summary>
    /// Implementation of the Steam news endpoint.
    /// </summary>
    public class SteamNewsEndpoint {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamNewsRawEndpoint Raw => Service.Client.News;

        #endregion

        #region Constructors

        internal SteamNewsEndpoint(SteamService service) {
            Service = service;
        }

        #endregion

        #region Member methods

        /// <summary>
        /// Gets a list of news items for the app (game) matching the specified <paramref name="appId"/>.
        /// </summary>
        /// <param name="appId">The app ID.</param>
        /// <param name="maxLength">The maximum length of the <see cref="SteamNewsItem.Contents"/> field.</param>
        /// <param name="endDate">The end date.</param>
        /// <param name="count">The maximum amount of news items to be returned.</param>
        /// <param name="feeds">The name of the feeds from which news items should be returned. If not specified, news items of all feeds will be returned.</param>
        /// <returns>An instance of <see cref="SteamGetNewsForAppResponse"/> representing the response.</returns>
        public SteamGetNewsForAppResponse GetNewsForApp(uint appId, uint maxLength = 0, EssentialsDateTime endDate = null, uint count = 0, string[] feeds = null) {
            return SteamGetNewsForAppResponse.ParseResponse(Raw.GetNewsForApp(appId, maxLength, endDate, count, feeds));
        }

        /// <summary>
        /// Gets a list of news items for the app (game) matching the specified <paramref name="options"/>.
        /// </summary>
        /// <param name="options">The options for the request to the API.</param>
        /// <returns>An instance of <see cref="SteamGetNewsForAppResponse"/> representing the response.</returns>
        public SteamGetNewsForAppResponse GetNewsForApp(SteamGetNewsForAppOptions options) {
            return SteamGetNewsForAppResponse.ParseResponse(Raw.GetNewsForApp(options));
        }

        #endregion

    }

}