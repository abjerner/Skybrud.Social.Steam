using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.OAuth;
using Skybrud.Social.Steam.Options.WebUserPresenceOAuth;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the Steam web user presence OAuth endpoint.
    /// </summary>
    public class SteamWebUserPresenceOAuthRawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal SteamWebUserPresenceOAuthRawEndpoint(SteamOAuthClient client)
        {
            Client = client;
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
        public SocialHttpResponse PollStatus(string steamId, ulong umqId, uint message, uint? pollId = null, uint? secTimeout = null, uint? secIdleTime = null, uint? useAccountIds = null)
        {
            return PollStatus(new SteamPollStatusOptions
            {
                SteamId = steamId,
                UmqId = umqId,
                Message = message,
                PollId = pollId,
                SecTimeout = secTimeout,
                SecIdleTime = secIdleTime,
                UseAccountIds = useAccountIds
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse PollStatus(SteamPollStatusOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpPostRequest("/ISteamWebUserPresenceOAuth/PollStatus/v1/", options);
        }

        #endregion

    }
}
