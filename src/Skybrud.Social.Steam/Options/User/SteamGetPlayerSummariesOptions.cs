using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.User
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting a list of summaries for players.
    /// </summary>
    public class SteamGetPlayerSummariesOptions : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the 64 bit Steam ids.
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
