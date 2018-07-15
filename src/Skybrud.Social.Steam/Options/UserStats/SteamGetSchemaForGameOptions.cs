using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.UserStats
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting the schema for a game.
    /// </summary>
    public class SteamGetSchemaForGameOptions : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the app id.
        /// </summary>
        public uint AppId { get; set; }

        /// <summary>
        /// Gets or sets the language.
        /// </summary>
        public string Lang { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            var qs = new SocialHttpQueryString();
            qs.Set("appid", AppId);
            if (!string.IsNullOrWhiteSpace(Lang)) qs.Set("l", Lang);
            return qs;
        }

        #endregion

    }
}
