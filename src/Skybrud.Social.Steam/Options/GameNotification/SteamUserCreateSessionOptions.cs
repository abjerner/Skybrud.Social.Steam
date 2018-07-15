using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.GameNotification
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for creating a user session.
    /// </summary>
    public class SteamUserCreateSessionOptions : IHttpPostOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the app id.
        /// </summary>
        public uint AppId { get; set; }

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        public ulong Context { get; set; }

        /// <summary>
        /// Gets or sets the 64 bit Steam id.
        /// </summary>
        public ulong? SteamId { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            return null;
        }

        public IHttpPostData GetPostData()
        {
            var data = new SocialHttpPostData {{"appid", AppId}, {"context", Context}};
            if (SteamId != null) data.Add("steamid", SteamId);
            return data;
        }

        #endregion

    }
}
