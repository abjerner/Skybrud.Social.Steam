using System;
using Skybrud.Essentials.Common;
using Skybrud.Essentials.Time;
using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;
using Skybrud.Social.Steam.Models.News;

namespace Skybrud.Social.Steam.Options.News {
    
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting news for an app.
    /// </summary>
    public class SteamGetNewsForAppOptions : IHttpGetOptions {

        #region Properties

        /// <summary>
        /// Gets or sets the app ID.
        /// </summary>
        public uint AppId { get; set; }

        /// <summary>
        /// Gets or sets the maximum length of the <see cref="SteamNewsItem.Contents"/> field.
        /// </summary>
        public uint MaxLength { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        public EssentialsDateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets the maximum amount of news items to be returned.
        /// </summary>
        public uint Count { get; set; }

        /// <summary>
        /// Gets or sets the name of the feeds from which news items should be returned. If not specified, news items of all feeds will be returned.
        /// </summary>
        public string[] Feeds { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Gets an instance of <see cref="IHttpQueryString"/> representing the GET parameters.
        /// </summary>
        public IHttpQueryString GetQueryString() {

            if (AppId == 0) throw new PropertyNotSetException(nameof(AppId));

            IHttpQueryString qs = new SocialHttpQueryString();

            qs.Set("appid", AppId);
            if (MaxLength > 0) qs.Set("maxlength", MaxLength);
            if (EndDate != null) qs.Set("enddate", EndDate);
            if (Count > 0) qs.Set("count", Count);
            if (Feeds != null && Feeds.Length > 0) qs.Set("feeds", String.Join(",", Feeds));

            return qs;

        }

        #endregion

    }
}
