using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.UserOAuth
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting token details.
    /// </summary>
    public class SteamGetTokenDetailsOptions : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        public string AccessToken { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            var qs = new SocialHttpQueryString();
            qs.Set("access_token", AccessToken);
            return qs;
        }

        #endregion

    }
}
