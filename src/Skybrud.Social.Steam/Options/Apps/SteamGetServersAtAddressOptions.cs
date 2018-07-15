using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.Apps
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting a list of servers at an address.
    /// </summary>
    public class SteamGetServersAtAddressOptions : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public string Addr { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            var qs = new SocialHttpQueryString();
            qs.Set("addr", Addr);
            return qs;
        }

        #endregion

    }
}
