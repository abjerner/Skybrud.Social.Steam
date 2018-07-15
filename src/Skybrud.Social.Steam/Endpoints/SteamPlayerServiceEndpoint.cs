using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Options.Player;
using Skybrud.Social.Steam.Responses.Player;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the player service endpoint.
    /// </summary>
    public class SteamPlayerServiceEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamPlayerServiceRawEndpoint Raw => Service.Client.Player;

        #endregion

        #region Constructors

        internal SteamPlayerServiceEndpoint(SteamService service)
        {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamId"></param>
        /// <param name="ticket"></param>
        /// <returns></returns>
        public SteamRecordOfflinePlaytimeResponse RecordOfflinePlaytime(ulong steamId, string ticket /*, message playSessions*/)
        {
            return SteamRecordOfflinePlaytimeResponse.ParseResponse(Raw.RecordOfflinePlaytime(steamId, ticket));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamRecordOfflinePlaytimeResponse RecordOfflinePlaytime(SteamRecordOfflinePlaytimeOptions options)
        {
            return SteamRecordOfflinePlaytimeResponse.ParseResponse(Raw.RecordOfflinePlaytime(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamId"></param>
        /// <param name="includeAppInfo"></param>
        /// <param name="includePlayedFreeGames"></param>
        /// <param name="appIdsFilter"></param>
        /// <returns></returns>
        public SteamGetOwnedGamesResponse GetOwnedGames(ulong steamId, bool? includeAppInfo = null, bool? includePlayedFreeGames = null, uint? appIdsFilter = null)
        {
            return SteamGetOwnedGamesResponse.ParseResponse(Raw.GetOwnedGames(steamId, includeAppInfo, includePlayedFreeGames, appIdsFilter));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetOwnedGamesResponse GetOwnedGames(SteamGetOwnedGamesOptions options)
        {
            return SteamGetOwnedGamesResponse.ParseResponse(Raw.GetOwnedGames(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamId"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public SteamGetRecentlyPlayedGamesResponse GetRecentlyPlayedGames(ulong steamId, uint? count = null)
        {
            return SteamGetRecentlyPlayedGamesResponse.ParseResponse(Raw.GetRecentlyPlayedGames(steamId, count));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetRecentlyPlayedGamesResponse GetRecentlyPlayedGames(SteamGetRecentlyPlayedGamesOptions options)
        {
            return SteamGetRecentlyPlayedGamesResponse.ParseResponse(Raw.GetRecentlyPlayedGames(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamId"></param>
        /// <param name="appIdPlaying"></param>
        /// <returns></returns>
        public SteamIsPlayingSharedGameResponse IsPlayingSharedGame(ulong steamId, uint appIdPlaying)
        {
            return SteamIsPlayingSharedGameResponse.ParseResponse(Raw.IsPlayingSharedGame(steamId, appIdPlaying));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamIsPlayingSharedGameResponse IsPlayingSharedGame(SteamIsPlayingSharedGameOptions options)
        {
            return SteamIsPlayingSharedGameResponse.ParseResponse(Raw.IsPlayingSharedGame(options));
        }

        #endregion

    }
}
