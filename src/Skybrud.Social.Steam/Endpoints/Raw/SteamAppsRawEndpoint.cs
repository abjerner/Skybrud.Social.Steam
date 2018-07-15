using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.OAuth;
using Skybrud.Social.Steam.Options.Apps;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the Steam apps endpoint.
    /// </summary>
    public class SteamAppsRawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal SteamAppsRawEndpoint(SteamOAuthClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SocialHttpResponse GetAppListv1()
        {
            return Client.DoHttpGetRequest("/ISteamApps/GetAppList/v1/");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SocialHttpResponse GetAppListv2()
        {
            return Client.DoHttpGetRequest("/ISteamApps/GetAppList/v2/");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="addr"></param>
        /// <returns></returns>
        public SocialHttpResponse GetServersAtAddress(string addr)
        {
            return GetServersAtAddress(new SteamGetServersAtAddressOptions {Addr = addr});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetServersAtAddress(SteamGetServersAtAddressOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamApps/GetServersAtAddress/v1/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="version"></param>
        /// <returns></returns>
        public SocialHttpResponse UpToDateCheck(uint appId, uint version)
        {
            return UpToDateCheck(new SteamUpToDateCheckOptions {AppId = appId, Version = version});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse UpToDateCheck(SteamUpToDateCheckOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamApps/UpToDateCheck/v1/", options);
        }

        #endregion

    }
}
