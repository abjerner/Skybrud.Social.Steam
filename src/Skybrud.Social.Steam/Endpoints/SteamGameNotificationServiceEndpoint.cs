using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Options.GameNotification;
using Skybrud.Social.Steam.Responses.GameNotification;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the game notification service endpoint.
    /// </summary>
    public class SteamGameNotificationServiceEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamGameNotificationServiceRawEndpoint Raw => Service.Client.GameNotification;

        #endregion

        #region Constructors

        internal SteamGameNotificationServiceEndpoint(SteamService service)
        {
            Service = service;
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
        public SteamUserCreateSessionResponse UserCreateSession(uint appId, ulong context /*, message title, message users*/, ulong steamId)
        {
            return SteamUserCreateSessionResponse.ParseResponse(Raw.UserCreateSession(appId, context, steamId));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamUserCreateSessionResponse UserCreateSession(SteamUserCreateSessionOptions options)
        {
            return SteamUserCreateSessionResponse.ParseResponse(Raw.UserCreateSession(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="appId"></param>
        /// <param name="steamId"></param>
        /// <returns></returns>
        public SteamUserUpdateSessionResponse UserUpdateSession(ulong sessionId, uint appId /*, message title, message users*/, ulong steamId)
        {
            return SteamUserUpdateSessionResponse.ParseResponse(Raw.UserUpdateSession(sessionId, appId, steamId));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamUserUpdateSessionResponse UserUpdateSession(SteamUserUpdateSessionOptions options)
        {
            return SteamUserUpdateSessionResponse.ParseResponse(Raw.UserUpdateSession(options));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="appId"></param>
        /// <param name="steamId"></param>
        /// <returns></returns>
        public SteamUserDeleteSessionResponse UserDeleteSession(ulong sessionId, uint appId, ulong steamId)
        {
            return SteamUserDeleteSessionResponse.ParseResponse(Raw.UserDeleteSession(sessionId, appId, steamId));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamUserDeleteSessionResponse UserDeleteSession(SteamUserDeleteSessionOptions options)
        {
            return SteamUserDeleteSessionResponse.ParseResponse(Raw.UserDeleteSession(options));
        }

        #endregion

    }
}
