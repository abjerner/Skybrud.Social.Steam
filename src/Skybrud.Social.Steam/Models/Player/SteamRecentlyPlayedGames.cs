using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.Player
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing recently played games as returned by the Steam api.
    /// </summary>
    public class SteamRecentlyPlayedGames : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamRecentlyPlayedGames(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamRecentlyPlayedGames"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamRecentlyPlayedGames"/>.</returns>
        public static SteamRecentlyPlayedGames Parse(JObject obj)
        {
            return obj == null ? null : new SteamRecentlyPlayedGames(obj);
        }

        #endregion

    }
}
