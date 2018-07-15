using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.Player
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing owned games as returned by the Steam api.
    /// </summary>
    public class SteamOwnedGames : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamOwnedGames(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamOwnedGames"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamOwnedGames"/>.</returns>
        public static SteamOwnedGames Parse(JObject obj)
        {
            return obj == null ? null : new SteamOwnedGames(obj);
        }

        #endregion

    }
}
