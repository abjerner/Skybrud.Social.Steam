using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.User
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting ban statuses for players.
    /// </summary>
    public class SteamGetPlayerBansOptions : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the 64 bit Steam id.
        /// </summary>
        public ulong[] SteamIds { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            var qs = new SocialHttpQueryString();
            qs.Set("steamids", SteamIds);
            return qs;
        }

        #endregion

    }
}
