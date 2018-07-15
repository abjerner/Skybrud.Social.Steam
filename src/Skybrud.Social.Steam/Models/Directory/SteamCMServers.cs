using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.Directory
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing Steam cm servers as returned by the Steam api.
    /// </summary>
    public class SteamCMServers : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamCMServers(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamCMServers"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamCMServers"/>.</returns>
        public static SteamCMServers Parse(JObject obj)
        {
            return obj == null ? null : new SteamCMServers(obj);
        }

        #endregion

    }
}
