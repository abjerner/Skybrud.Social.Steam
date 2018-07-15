using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.OAuth;
using Skybrud.Social.Steam.Options.Portal2Leaderboards;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the portal 2 leaderboards 841 endpoint.
    /// </summary>
    public class SteamPortal2Leaderboards841RawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal SteamPortal2Leaderboards841RawEndpoint(SteamOAuthClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="leaderboardName"></param>
        /// <returns></returns>
        public SocialHttpResponse GetBucketizedData(string leaderboardName)
        {
            return GetBucketizedData(new SteamGetBucketizedDataOptions {LeaderboardName = leaderboardName});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetBucketizedData(SteamGetBucketizedDataOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/IPortal2Leadboards_841/GetBucketizedData/v1/", options);
        }

        #endregion

    }
}
