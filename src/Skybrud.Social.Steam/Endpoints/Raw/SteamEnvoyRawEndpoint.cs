using Skybrud.Social.Http;
using Skybrud.Social.Steam.OAuth;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the Steam envoy endpoint.
    /// </summary>
    public class SteamEnvoyRawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamOAuthClient Client { get; }

        #endregion

        #region Constructors

        internal SteamEnvoyRawEndpoint(SteamOAuthClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SocialHttpResponse PaymentOutReversalNotification()
        {
            return Client.DoHttpPostRequest("/ISteamEnvoy/PaymentOutReversalNotification/v1/");
        }

        #endregion

    }
}
