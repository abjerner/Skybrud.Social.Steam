using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.UserStats
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting global stats for a game.
    /// </summary>
    public class SteamGetGlobalStatsForGameOptions : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the app id.
        /// </summary>
        public uint AppId { get; set; }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        public uint Count { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the unix epoch start date.
        /// </summary>
        public uint? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the unix epoch end date.
        /// </summary>
        public uint? EndDate { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            var qs = new SocialHttpQueryString();
            qs.Set("appid", AppId);
            qs.Set("count", Count);
            qs.Set("name[0]", Name);
            if (StartDate != null) qs.Set("startdate", StartDate);
            if (EndDate != null) qs.Set("enddate", EndDate);
            return qs;
        }

        #endregion

    }
}
