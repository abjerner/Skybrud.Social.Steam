using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Options.WebUserPresenceOAuth;
using Skybrud.Social.Steam.Responses.WebUserPresenceOAuth;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the web user presence OAuth endpoint.
    /// </summary>
    public class SteamWebUserPresenceOAuthEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamWebUserPresenceOAuthRawEndpoint Raw => Service.Client.WebUserPresenceOAuth;

        #endregion

        #region Constructors

        internal SteamWebUserPresenceOAuthEndpoint(SteamService service)
        {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamId"></param>
        /// <param name="umqId"></param>
        /// <param name="message"></param>
        /// <param name="pollId"></param>
        /// <param name="secTimeout"></param>
        /// <param name="secIdleTime"></param>
        /// <param name="useAccountIds"></param>
        /// <returns></returns>
        public SteamPollStatusResponse PollStatus(string steamId, ulong umqId, uint message, uint? pollId = null, uint? secTimeout = null, uint? secIdleTime = null, uint? useAccountIds = null)
        {
            return SteamPollStatusResponse.ParseResponse(Raw.PollStatus(steamId, umqId, message, pollId, secTimeout, secIdleTime, useAccountIds));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamPollStatusResponse PollStatus(SteamPollStatusOptions options)
        {
            return SteamPollStatusResponse.ParseResponse(Raw.PollStatus(options));
        }

        #endregion

    }
}
