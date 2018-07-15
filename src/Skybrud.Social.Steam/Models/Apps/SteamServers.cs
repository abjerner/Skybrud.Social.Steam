using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.Apps
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing Steam servers as returned by the Steam api.
    /// </summary>
    public class SteamServers : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamServers(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamServers"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamServers"/>.</returns>
        public static SteamServers Parse(JObject obj)
        {
            return obj == null ? null : new SteamServers(obj);
        }

        #endregion

    }
}
