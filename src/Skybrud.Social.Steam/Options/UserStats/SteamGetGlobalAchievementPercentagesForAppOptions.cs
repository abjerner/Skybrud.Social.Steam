using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.UserStats
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting global achievement percentages for an app.
    /// </summary>
    public class SteamGetGlobalAchievementPercentagesForAppOptions : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the game id.
        /// </summary>
        public ulong GameId { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            var qs = new SocialHttpQueryString();
            qs.Set("gameid", GameId);
            return qs;
        }

        #endregion

    }
}
