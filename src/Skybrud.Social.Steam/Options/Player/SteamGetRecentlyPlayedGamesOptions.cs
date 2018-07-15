using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.Player
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting a list of recently played games.
    /// </summary>
    public class SteamGetRecentlyPlayedGamesOptions : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the 64 bit Steam id.
        /// </summary>
        public ulong SteamId { get; set; }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        public uint? Count { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            var qs = new SocialHttpQueryString();
            qs.Set("steamid", SteamId);
            if (Count != null) qs.Set("count", Count);
            return qs;
        }

        #endregion

    }
}
