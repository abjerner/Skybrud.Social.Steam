using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.Player
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing whether a player is playing a shared game as returned by the Steam api.
    /// </summary>
    public class SteamIsPlayingSharedGame : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamIsPlayingSharedGame(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamIsPlayingSharedGame"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamIsPlayingSharedGame"/>.</returns>
        public static SteamIsPlayingSharedGame Parse(JObject obj)
        {
            return obj == null ? null : new SteamIsPlayingSharedGame(obj);
        }

        #endregion

    }
}
