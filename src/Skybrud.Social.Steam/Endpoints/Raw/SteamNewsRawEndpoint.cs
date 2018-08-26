using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Options.News;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the Steam news endpoint.
    /// </summary>
    public class SteamNewsRawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamHttpClient Client { get; }

        #endregion

        #region Constructors

        internal SteamNewsRawEndpoint(SteamHttpClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="maxLength"></param>
        /// <param name="endDate"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public SocialHttpResponse GetNewsForAppv1(uint appId, uint? maxLength = null, uint? endDate = null, uint? count = null)
        {
            return GetNewsForAppv1(new SteamGetNewsForAppv1Options
            {
                AppId = appId,
                MaxLength = maxLength,
                EndDate = endDate,
                Count = count
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetNewsForAppv1(SteamGetNewsForAppv1Options options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamNews/GetNewsForApp/v1/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="maxLength"></param>
        /// <param name="endDate"></param>
        /// <param name="count"></param>
        /// <param name="feeds"></param>
        /// <returns></returns>
        public SocialHttpResponse GetNewsForAppv2(uint appId, uint? maxLength = null, uint? endDate = null, uint? count = null, string feeds = null)
        {
            return GetNewsForAppv2(new SteamGetNewsForAppv2Options
            {
                AppId = appId,
                MaxLength = maxLength,
                EndDate = endDate,
                Count = count,
                Feeds = feeds
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetNewsForAppv2(SteamGetNewsForAppv2Options options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamNews/GetNewsForApp/v2/", options);
        }

        #endregion

    }
}
