using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.Directory
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for getting a list of servers.
    /// </summary>
    public class SteamGetCSListOptions : IHttpGetOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the cell id.
        /// </summary>
        public uint CellId { get; set; }

        /// <summary>
        /// Gets or sets the max count.
        /// </summary>
        public uint? MaxCount { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            var qs = new SocialHttpQueryString();
            qs.Set("cellid", CellId);
            if (MaxCount != null) qs.Set("maxcount", MaxCount);
            return qs;
        }

        #endregion

    }
}
