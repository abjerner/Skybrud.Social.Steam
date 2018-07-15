using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.GameNotification
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for updating a user session.
    /// </summary>
    public class SteamUserUpdateSessionOptions : IHttpPostOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the session id.
        /// </summary>
        public ulong SessionId { get; set; }

        /// <summary>
        /// Gets or sets the app id.
        /// </summary>
        public uint AppId { get; set; }

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
            var data = new SocialHttpPostData {{"sessionid", SessionId}, {"appid", AppId}};
            if (SteamId != null) data.Add("steamid", SteamId);
            return data;
        }

        #endregion

    }
}
