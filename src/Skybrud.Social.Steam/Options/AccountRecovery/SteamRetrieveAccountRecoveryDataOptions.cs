using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.AccountRecovery
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for retrieving account recovery data.
    /// </summary>
    public class SteamRetrieveAccountRecoveryDataOptions : IHttpPostOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the request handle.
        /// </summary>
        public string RequestHandle { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            return null;
        }

        public IHttpPostData GetPostData()
        {
            var data = new SocialHttpPostData {{"requesthandle", RequestHandle}};
            return data;
        }

        #endregion

    }
}
