using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Options.User;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the Steam user endpoint.
    /// </summary>
    public class SteamUserRawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamHttpClient Client { get; }

        #endregion

        #region Constructors

        internal SteamUserRawEndpoint(SteamHttpClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamIds"></param>
        /// <returns></returns>
        public SocialHttpResponse GetPlayerSummaries(params ulong[] steamIds)
        {
            return GetPlayerSummaries(new SteamGetPlayerSummariesOptions {SteamIds = steamIds});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetPlayerSummaries(SteamGetPlayerSummariesOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamUser/GetPlayerSummaries/v2/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamId"></param>
        /// <param name="relationship"></param>
        /// <returns></returns>
        public SocialHttpResponse GetFriendList(ulong steamId, string relationship)
        {
            return GetFriendList(new SteamGetFriendListOptions {SteamId = steamId, Relationship = relationship});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetFriendList(SteamGetFriendListOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamUser/GetFriendList/v1/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steadIds"></param>
        /// <returns></returns>
        public SocialHttpResponse GetPlayerBans(ulong[] steadIds)
        {
            return GetPlayerBans(new SteamGetPlayerBansOptions {SteamIds = steadIds});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetPlayerBans(SteamGetPlayerBansOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamUser/GetPlayerBans/v1/", options);
        }

        #endregion

    }
}
