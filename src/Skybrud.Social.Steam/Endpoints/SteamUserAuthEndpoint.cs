using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Options.UserAuth;
using Skybrud.Social.Steam.Responses.UserAuth;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the Steam user auth endpoint.
    /// </summary>
    public class SteamUserAuthEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamUserAuthRawEndpoint Raw => Service.Client.UserAuth;

        #endregion

        #region Constructors

        internal SteamUserAuthEndpoint(SteamService service)
        {
            Service = service;
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
        public SteamAuthenticateUserResponse AuthenticateUser(ulong steamId, byte[] sessionKey, byte[] encryptedLoginKey)
        {
            return SteamAuthenticateUserResponse.ParseResponse(Raw.AuthenticateUser(steamId, sessionKey, encryptedLoginKey));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamAuthenticateUserResponse AuthenticateUser(SteamAuthenticateUserOptions options)
        {
            return SteamAuthenticateUserResponse.ParseResponse(Raw.AuthenticateUser(options));
        }

        #endregion

    }
}
