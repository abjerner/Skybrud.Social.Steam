using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.OAuth;
using Skybrud.Social.Steam.Options.Player;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the player service endpoint.
    /// </summary>
    public class SteamPlayerServiceRawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal SteamPlayerServiceRawEndpoint(SteamOAuthClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamId"></param>
        /// <param name="ticket"></param>
        /// <returns></returns>
        // Need to figure out playSessions
        public SocialHttpResponse RecordOfflinePlaytime(ulong steamId, string ticket /*, message playSessions*/)
        {
            return RecordOfflinePlaytime(new SteamRecordOfflinePlaytimeOptions {SteamId = steamId, Ticket = ticket});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse RecordOfflinePlaytime(SteamRecordOfflinePlaytimeOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpPostRequest("/IPlayerService/RecordOfflinePlaytime/v1/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamId"></param>
        /// <param name="includeAppInfo"></param>
        /// <param name="includePlayedFreeGames"></param>
        /// <param name="appIdsFilter"></param>
        /// <returns></returns>
        public SocialHttpResponse GetOwnedGames(ulong steamId, bool? includeAppInfo = null, bool? includePlayedFreeGames = null, uint? appIdsFilter = null)
        {
            return GetOwnedGames(new SteamGetOwnedGamesOptions
            {
                SteamId = steamId,
                IncludeAppInfo = includeAppInfo,
                IncludePlayedFreeGames = includePlayedFreeGames,
                AppIdsFilter = appIdsFilter
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetOwnedGames(SteamGetOwnedGamesOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/IPlayerService/GetOwnedGames/v1/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamId"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public SocialHttpResponse GetRecentlyPlayedGames(ulong steamId, uint? count = null)
        {
            return GetRecentlyPlayedGames(new SteamGetRecentlyPlayedGamesOptions {SteamId = steamId, Count = count});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetRecentlyPlayedGames(SteamGetRecentlyPlayedGamesOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/IPlayerService/GetRecentlyPlayedGames/v1/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamId"></param>
        /// <param name="appIdPlaying"></param>
        /// <returns></returns>
        public SocialHttpResponse IsPlayingSharedGame(ulong steamId, uint appIdPlaying)
        {
            return IsPlayingSharedGame(new SteamIsPlayingSharedGameOptions {SteamId = steamId, AppIdPlaying = appIdPlaying});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse IsPlayingSharedGame(SteamIsPlayingSharedGameOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/IPlayerService/IsPlayingSharedGame/v1/", options);
        }

        #endregion

    }
}
