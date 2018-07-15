using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.Apps
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing Steam up to date check as returned by the Steam api.
    /// </summary>
    public class SteamUpToDateCheck : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamUpToDateCheck(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamUpToDateCheck"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamUpToDateCheck"/>.</returns>
        public static SteamUpToDateCheck Parse(JObject obj)
        {
            return obj == null ? null : new SteamUpToDateCheck(obj);
        }

        #endregion

    }
}
