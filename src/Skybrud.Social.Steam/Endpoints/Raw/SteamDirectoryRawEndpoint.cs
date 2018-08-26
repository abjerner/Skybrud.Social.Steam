using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Options.Directory;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the Steam directory endpoint.
    /// </summary>
    public class SteamDirectoryRawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamHttpClient Client { get; }

        #endregion

        #region Constructors

        internal SteamDirectoryRawEndpoint(SteamHttpClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cellId"></param>
        /// <param name="maxCount"></param>
        /// <returns></returns>
        public SocialHttpResponse GetCMList(uint cellId, uint? maxCount = null)
        {
            return GetCMList(new SteamGetCMListOptions {CellId = cellId, MaxCount = maxCount});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetCMList(SteamGetCMListOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamDirectory/GetCMList/v1/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cellId"></param>
        /// <param name="maxCount"></param>
        /// <returns></returns>
        public SocialHttpResponse GetCSList(uint cellId, uint? maxCount = null)
        {
            return GetCSList(new SteamGetCSListOptions {CellId = cellId, MaxCount = maxCount});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetCSList(SteamGetCSListOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamDirectory/GetCSList/v1/", options);
        }

        #endregion

    }
}
