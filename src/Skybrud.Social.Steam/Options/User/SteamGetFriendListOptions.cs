using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.User
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting a list of friends for a player.
    /// </summary>
    public class SteamGetFriendListOptions : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the 64 bit Steam id.
        /// </summary>
        public ulong SteamId { get; set; }

        /// <summary>
        /// Gets or sets the relationship filter.
        /// </summary>
        public string Relationship { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            var qs = new SocialHttpQueryString();
            qs.Set("steamid", SteamId);
            qs.Set("relationship", Relationship);
            return qs;
        }

        #endregion

    }
}
