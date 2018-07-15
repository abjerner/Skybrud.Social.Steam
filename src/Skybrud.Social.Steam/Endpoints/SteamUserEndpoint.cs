using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Options.User;
using Skybrud.Social.Steam.Responses.User;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the Steam user endpoint.
    /// </summary>
    public class SteamUserEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamUserRawEndpoint Raw => Service.Client.User;

        #endregion

        #region Constructors

        internal SteamUserEndpoint(SteamService service)
        {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamIds"></param>
        /// <returns></returns>
        public SteamGetPlayerSummariesResponse GetPlayerSummaries(params ulong[] steamIds)
        {
            return SteamGetPlayerSummariesResponse.ParseResponse(Raw.GetPlayerSummaries(steamIds));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetPlayerSummariesResponse GetPlayerSummaries(SteamGetPlayerSummariesOptions options)
        {
            return SteamGetPlayerSummariesResponse.ParseResponse(Raw.GetPlayerSummaries(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamId"></param>
        /// <param name="relationship"></param>
        /// <returns></returns>
        public SteamGetFriendListResponse GetFriendList(ulong steamId, string relationship)
        {
            return SteamGetFriendListResponse.ParseResponse(Raw.GetFriendList(steamId, relationship));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetFriendListResponse GetFriendList(SteamGetFriendListOptions options)
        {
            return SteamGetFriendListResponse.ParseResponse(Raw.GetFriendList(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steadIds"></param>
        /// <returns></returns>
        public SteamGetPlayerBansResponse GetPlayerBans(ulong[] steadIds)
        {
            return SteamGetPlayerBansResponse.ParseResponse(Raw.GetPlayerBans(steadIds));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetPlayerBansResponse GetPlayerBans(SteamGetPlayerBansOptions options)
        {
            return SteamGetPlayerBansResponse.ParseResponse(Raw.GetPlayerBans(options));
        }

        #endregion

    }
}
