using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Options.UserStats;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the Steam user stats endpoint.
    /// </summary>
    public class SteamUserStatsRawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamHttpClient Client { get; }

        #endregion

        #region Constructors

        internal SteamUserStatsRawEndpoint(SteamHttpClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        public SocialHttpResponse GetGlobalAchievementPercentagesForAppv1(ulong gameId)
        {
            return GetGlobalAchievementPercentagesForAppv1(new SteamGetGlobalAchievementPercentagesForAppOptions {GameId = gameId});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetGlobalAchievementPercentagesForAppv1(SteamGetGlobalAchievementPercentagesForAppOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamUserStats/GetGlobalAchievementPercentagesForApp/v1/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gameId"></param>
        /// <returns></returns>
        public SocialHttpResponse GetGlobalAchievementPercentagesForAppv2(ulong gameId)
        {
            return GetGlobalAchievementPercentagesForAppv2(new SteamGetGlobalAchievementPercentagesForAppOptions {GameId = gameId});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetGlobalAchievementPercentagesForAppv2(SteamGetGlobalAchievementPercentagesForAppOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamUserStats/GetGlobalAchievementPercentagesForApp/v2/", options);
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
        public SocialHttpResponse GetGlobalStatsForGame(uint appId, uint count, string name, uint? startDate = null, uint? endDate = null)
        {
            return GetGlobalStatsForGame(new SteamGetGlobalStatsForGameOptions
            {
                AppId = appId,
                Count = count,
                Name = name,
                StartDate = startDate,
                EndDate = endDate
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetGlobalStatsForGame(SteamGetGlobalStatsForGameOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamUserStats/GetGlobalStatsForGame/v1/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appId"></param>
        /// <returns></returns>
        public SocialHttpResponse GetNumberOfCurrentPlayers(uint appId)
        {
            return GetNumberOfCurrentPlayers(new SteamGetNumberOfCurrentPlayersOptions {AppId = appId});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetNumberOfCurrentPlayers(SteamGetNumberOfCurrentPlayersOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamUserStats/GetNumberOfCurrentPlayers/v1/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamId"></param>
        /// <param name="appId"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        public SocialHttpResponse GetPlayerAchievements(ulong steamId, uint appId, string lang = null)
        {
            return GetPlayerAchievements(new SteamGetPlayerAchievementsOptions {SteamId = steamId, AppId = appId, Lang = lang});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetPlayerAchievements(SteamGetPlayerAchievementsOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamUserStats/GetPlayerAchievements/v1/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamId"></param>
        /// <param name="appId"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        public SocialHttpResponse GetUserStatsForGame(ulong steamId, uint appId, string lang = null)
        {
            return GetUserStatsForGame(new StreamGetUserStatsForGameOptions {SteamId = steamId, AppId = appId, Lang = lang});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetUserStatsForGame(StreamGetUserStatsForGameOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamUserStats/GetUserStatsForGame/v2/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        public SocialHttpResponse GetSchemaForGame(uint appId, string lang = null)
        {
            return GetSchemaForGame(new SteamGetSchemaForGameOptions {AppId = appId, Lang = lang});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetSchemaForGame(SteamGetSchemaForGameOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamUserStats/GetSchemaForGame/v2/", options);
        }

        #endregion

    }
}
