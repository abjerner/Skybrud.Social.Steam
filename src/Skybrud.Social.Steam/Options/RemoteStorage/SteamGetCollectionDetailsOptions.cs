using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.RemoteStorage
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting collection details.
    /// </summary>
    public class SteamGetCollectionDetailsOptions : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the collection count.
        /// </summary>
        public uint CollectionCount { get; set; }

        /// <summary>
        /// Gets or sets the published fields.
        /// </summary>
        public ulong PublishedFields { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            var qs = new SocialHttpQueryString();
            qs.Set("collectioncount", CollectionCount);
            qs.Set("publishedfields[0]", PublishedFields);
            return qs;
        }

        #endregion

    }
}
