using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Options.GameNotification;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the game notification service endpoint.
    /// </summary>
    public class SteamGameNotificationServiceRawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamHttpClient Client { get; }

        #endregion

        #region Constructors

        internal SteamGameNotificationServiceRawEndpoint(SteamHttpClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="appId"></param>
        /// <param name="context"></param>
        /// <param name="steamId"></param>
        /// <returns></returns>
        // Need to figure out title and users
        public SocialHttpResponse UserCreateSession(uint appId, ulong context /*, message title, message users*/, ulong? steamId = null)
        {
            return UserCreateSession(new SteamUserCreateSessionOptions {AppId = appId, Context = context, SteamId = steamId});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse UserCreateSession(SteamUserCreateSessionOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpPostRequest("/IGameNotificationService/UserCreateSession/v1/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="appId"></param>
        /// <param name="steamId"></param>
        /// <returns></returns>
        public SocialHttpResponse UserUpdateSession(ulong sessionId, uint appId /*, message title, message users*/, ulong? steamId = null)
        {
            return UserUpdateSession(new SteamUserUpdateSessionOptions {SessionId = sessionId, AppId = appId, SteamId = steamId});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse UserUpdateSession(SteamUserUpdateSessionOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpPostRequest("/IGameNotificationService/UserUpdateSession/v1/", options);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="appId"></param>
        /// <param name="steamId"></param>
        /// <returns></returns>
        public SocialHttpResponse UserDeleteSession(ulong sessionId, uint appId, ulong? steamId = null)
        {
            return UserDeleteSession(new SteamUserDeleteSessionOptions {SessionId = sessionId, AppId = appId, SteamId = steamId});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse UserDeleteSession(SteamUserDeleteSessionOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpPostRequest("/IGameNotificationService/UserDeleteSession/v1/", options);
        }

        #endregion

    }
}
