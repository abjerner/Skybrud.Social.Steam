using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.Player
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for recording offline playtime.
    /// </summary>
    public class SteamRecordOfflinePlaytimeOptions : IHttpPostOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the 64 bit Steam id.
        /// </summary>
        public ulong SteamId { get; set; }

        /// <summary>
        /// Gets or sets the ticket.
        /// </summary>
        public string Ticket { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            return null;
        }

        public IHttpPostData GetPostData()
        {
            var data = new SocialHttpPostData {{"steamid", SteamId}, {"ticket", Ticket}};
            return data;
        }

        #endregion

    }
}
