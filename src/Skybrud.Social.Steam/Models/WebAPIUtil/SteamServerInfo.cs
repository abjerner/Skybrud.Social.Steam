using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.WebAPIUtil
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing Steam server info as returned by the Steam api.
    /// </summary>
    public class SteamServerInfo : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamServerInfo(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamServerInfo"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamServerInfo"/>.</returns>
        public static SteamServerInfo Parse(JObject obj)
        {
            return obj == null ? null : new SteamServerInfo(obj);
        }

        #endregion

    }
}
