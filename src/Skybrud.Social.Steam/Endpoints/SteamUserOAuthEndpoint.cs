using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Options.UserOAuth;
using Skybrud.Social.Steam.Responses.UserOAuth;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the user OAuth endpoint.
    /// </summary>
    public class SteamUserOAuthEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamUserOAuthRawEndpoint Raw => Service.Client.UserOAuth;

        #endregion

        #region Constructors

        internal SteamUserOAuthEndpoint(SteamService service)
        {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public SteamGetTokenDetailsResponse GetTokenDetails(string accessToken)
        {
            return SteamGetTokenDetailsResponse.ParseResponse(Raw.GetTokenDetails(accessToken));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public SteamGetTokenDetailsResponse GetTokenDetails(SteamGetTokenDetailsOptions options)
        {
            return SteamGetTokenDetailsResponse.ParseResponse(Raw.GetTokenDetails(options));
        }

        #endregion

    }
}
