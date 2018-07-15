using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.GCVersion
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing Steam client version as returned by the Steam api.
    /// </summary>
    public class SteamClientVersion : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamClientVersion(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamClientVersion"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamClientVersion"/>.</returns>
        public static SteamClientVersion Parse(JObject obj)
        {
            return obj == null ? null : new SteamClientVersion(obj);
        }

        #endregion

    }
}
