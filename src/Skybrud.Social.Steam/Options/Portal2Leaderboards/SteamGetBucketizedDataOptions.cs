using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.Portal2Leaderboards
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting bucketized data.
    /// </summary>
    public class SteamGetBucketizedDataOptions : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the leaderboard name.
        /// </summary>
        public string LeaderboardName { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            var qs = new SocialHttpQueryString();
            qs.Set("leaderboardName", LeaderboardName);
            return qs;
        }

        #endregion

    }
}
