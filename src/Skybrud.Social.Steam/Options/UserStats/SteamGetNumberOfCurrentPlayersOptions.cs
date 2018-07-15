using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.UserStats
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting the number of current players.
    /// </summary>
    public class SteamGetNumberOfCurrentPlayersOptions : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the app id.
        /// </summary>
        public uint AppId { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            var qs = new SocialHttpQueryString();
            qs.Set("appid", AppId);
            return qs;
        }

        #endregion

    }
}
