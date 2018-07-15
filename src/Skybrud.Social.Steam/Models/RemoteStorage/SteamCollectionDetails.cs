using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.RemoteStorage
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing Steam collection details as returned by the Steam api.
    /// </summary>
    public class SteamCollectionDetails : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamCollectionDetails(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamCollectionDetails"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamCollectionDetails"/>.</returns>
        public static SteamCollectionDetails Parse(JObject obj)
        {
            return obj == null ? null : new SteamCollectionDetails(obj);
        }

        #endregion

    }
}
