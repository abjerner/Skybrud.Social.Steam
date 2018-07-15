using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.User
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing player bans as returned by the Steam api.
    /// </summary>
    public class SteamPlayerBans : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamPlayerBans(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamPlayerBans"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamPlayerBans"/>.</returns>
        public static SteamPlayerBans Parse(JObject obj)
        {
            return obj == null ? null : new SteamPlayerBans(obj);
        }

        #endregion

    }
}
