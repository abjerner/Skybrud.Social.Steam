using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Options.UserAuth;

namespace Skybrud.Social.Steam.Endpoints.Raw
{
    /// <summary>
    /// Class representing the raw implementation of the Steam user auth endpoint.
    /// </summary>
    public class SteamUserAuthRawEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the OAuth client.
        /// </summary>
        public SteamHttpClient Client { get; }

        #endregion

        #region Constructors

        internal SteamUserAuthRawEndpoint(SteamHttpClient client)
        {
            Client = client;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamId"></param>
        /// <param name="sessionKey"></param>
        /// <param name="encryptedLoginKey"></param>
        /// <returns></returns>
        public SocialHttpResponse AuthenticateUser(ulong steamId, byte[] sessionKey, byte[] encryptedLoginKey)
        {
            return AuthenticateUser(new SteamAuthenticateUserOptions
            {
                SteamId = steamId,
                SessionKey = sessionKey,
                EncryptedLoginKey = encryptedLoginKey
            });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SocialHttpResponse AuthenticateUser(SteamAuthenticateUserOptions options)
        {
            // Some validation
            if (options == null) throw new ArgumentNullException(nameof(options));
            return Client.DoHttpPostRequest("/ISteamUserAuth/AuthenticateUser/v1/", options);
        }

        #endregion

    }
}
