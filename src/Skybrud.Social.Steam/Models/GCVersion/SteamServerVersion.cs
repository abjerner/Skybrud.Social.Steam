using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.GCVersion
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing Steam server version as returned by the Steam api.
    /// </summary>
    public class SteamServerVersion : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamServerVersion(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamServerVersion"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamServerVersion"/>.</returns>
        public static SteamServerVersion Parse(JObject obj)
        {
            return obj == null ? null : new SteamServerVersion(obj);
        }

        #endregion

    }
}
