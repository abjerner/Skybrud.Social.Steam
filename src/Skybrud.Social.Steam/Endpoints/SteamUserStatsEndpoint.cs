using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Options.UserStats;
using Skybrud.Social.Steam.Responses.UserStats;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the Steam user stats endpoint.
    /// </summary>
    public class SteamUserStatsEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamUserStatsRawEndpoint Raw => Service.Client.UserStats;

        #endregion

        #region Constructors

        internal SteamUserStatsEndpoint(SteamService service)
        {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        public SteamGetGlobalAchievementPercentagesForAppv1Response GetGlobalAchievementPercentagesForAppv1(ulong gameId)
        {
            return SteamGetGlobalAchievementPercentagesForAppv1Response.ParseResponse(Raw.GetGlobalAchievementPercentagesForAppv1(gameId));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetGlobalAchievementPercentagesForAppv1Response GetGlobalAchievementPercentagesForAppv1(SteamGetGlobalAchievementPercentagesForAppOptions options)
        {
            return SteamGetGlobalAchievementPercentagesForAppv1Response.ParseResponse(Raw.GetGlobalAchievementPercentagesForAppv1(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        public SteamGetGlobalAchievementPercentagesForAppv2Response GetGlobalAchievementPercentagesForAppv2(ulong gameId)
        {
            return SteamGetGlobalAchievementPercentagesForAppv2Response.ParseResponse(Raw.GetGlobalAchievementPercentagesForAppv2(gameId));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetGlobalAchievementPercentagesForAppv2Response GetGlobalAchievementPercentagesForAppv2(SteamGetGlobalAchievementPercentagesForAppOptions options)
        {
            return SteamGetGlobalAchievementPercentagesForAppv2Response.ParseResponse(Raw.GetGlobalAchievementPercentagesForAppv2(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="count"></param>
        /// <param name="name"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <returns></returns>
        public SteamGetGlobalStatsForGameResponse GetGlobalStatsForGame(uint appId, uint count, string name, uint? startDate = null, uint? endDate = null)
        {
            return SteamGetGlobalStatsForGameResponse.ParseResponse(Raw.GetGlobalStatsForGame(appId, count, name, startDate, endDate));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetGlobalStatsForGameResponse GetGlobalStatsForGame(SteamGetGlobalStatsForGameOptions options)
        {
            return SteamGetGlobalStatsForGameResponse.ParseResponse(Raw.GetGlobalStatsForGame(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public SteamGetNumberOfCurrentPlayersResponse GetNumberOfCurrentPlayers(uint appId)
        {
            return SteamGetNumberOfCurrentPlayersResponse.ParseResponse(Raw.GetNumberOfCurrentPlayers(appId));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetNumberOfCurrentPlayersResponse GetNumberOfCurrentPlayers(SteamGetNumberOfCurrentPlayersOptions options)
        {
            return SteamGetNumberOfCurrentPlayersResponse.ParseResponse(Raw.GetNumberOfCurrentPlayers(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamId"></param>
        /// <param name="appId"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        public SteamGetPlayerAchievementsResponse GetPlayerAchievements(ulong steamId, uint appId, string lang = null)
        {
            return SteamGetPlayerAchievementsResponse.ParseResponse(Raw.GetPlayerAchievements(steamId, appId, lang));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetPlayerAchievementsResponse GetPlayerAchievements(SteamGetPlayerAchievementsOptions options)
        {
            return SteamGetPlayerAchievementsResponse.ParseResponse(Raw.GetPlayerAchievements(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamId"></param>
        /// <param name="appId"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        public SteamGetUserStatsForGameResponse GetUserStatsForGame(ulong steamId, uint appId, string lang)
        {
            return SteamGetUserStatsForGameResponse.ParseResponse(Raw.GetUserStatsForGame(steamId, appId, lang));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetUserStatsForGameResponse GetUserStatsForGame(StreamGetUserStatsForGameOptions options)
        {
            return SteamGetUserStatsForGameResponse.ParseResponse(Raw.GetUserStatsForGame(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        public SteamGetSchemaForGameResponse GetSchemaForGame(uint appId, string lang = null)
        {
            return SteamGetSchemaForGameResponse.ParseResponse(Raw.GetSchemaForGame(appId, lang));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetSchemaForGameResponse GetSchemaForGame(SteamGetSchemaForGameOptions options)
        {
            return SteamGetSchemaForGameResponse.ParseResponse(Raw.GetSchemaForGame(options));
        }

        #endregion

    }
}
