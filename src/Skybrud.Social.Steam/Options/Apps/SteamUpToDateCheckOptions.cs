using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.Apps
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for checking if a game is up to date.
    /// </summary>
    public class SteamUpToDateCheckOptions : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the app id.
        /// </summary>
        public uint AppId { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        public uint Version { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            var qs = new SocialHttpQueryString();
            qs.Set("appid", AppId);
            qs.Set("version", Version);
            return qs;
        }

        #endregion

    }
}
