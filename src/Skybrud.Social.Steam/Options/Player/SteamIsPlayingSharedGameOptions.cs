using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.Player
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting whether or not a user is playing a shared game.
    /// </summary>
    public class SteamIsPlayingSharedGameOptions : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the 64 bit Steam id.
        /// </summary>
        public ulong SteamId { get; set; }

        /// <summary>
        /// Gets or sets the app id that is being played.
        /// </summary>
        public uint AppIdPlaying { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            var qs = new SocialHttpQueryString();
            qs.Set("steamid", SteamId);
            qs.Set("appid_playing", AppIdPlaying);
            return qs;
        }

        #endregion

    }
}
