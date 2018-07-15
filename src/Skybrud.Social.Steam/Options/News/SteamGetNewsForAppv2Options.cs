using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.News
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting news for an app.
    /// </summary>
    public class SteamGetNewsForAppv2Options : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the app id.
        /// </summary>
        public uint AppId { get; set; }

        /// <summary>
        /// Gets or sets the max length.
        /// </summary>
        public uint? MaxLength { get; set; }

        /// <summary>
        /// Gets or sets the unix epoch end date.
        /// </summary>
        public uint? EndDate { get; set; }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        public uint? Count { get; set; }

        /// <summary>
        /// Gets or sets the feeds.
        /// </summary>
        public string Feeds { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            var qs = new SocialHttpQueryString();
            qs.Set("appid", AppId);
            if (MaxLength != null) qs.Set("maxlength", MaxLength);
            if (EndDate != null) qs.Set("enddate", EndDate);
            if (Count != null) qs.Set("count", Count);
            if (!string.IsNullOrWhiteSpace(Feeds)) qs.Set("feeds", Feeds);
            return qs;
        }

        #endregion

    }
}
