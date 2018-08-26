using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Options.UserOAuth;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the Steam user OAuth endpoint.
    /// </summary>
    public class SteamUserOAuthRawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamHttpClient Client { get; }

        #endregion

        #region Constructors

        internal SteamUserOAuthRawEndpoint(SteamHttpClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public SocialHttpResponse GetTokenDetails(string accessToken)
        {
            return GetTokenDetails(new SteamGetTokenDetailsOptions {AccessToken = accessToken});
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse GetTokenDetails(SteamGetTokenDetailsOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpGetRequest("/ISteamUserOAuth/GetTokenDetails/v1/", options);
        }

        #endregion

    }
}
