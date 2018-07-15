using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.UserStats
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing number of current players as returned by the Steam api.
    /// </summary>
    public class SteamNumberOfCurrentPlayers : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamNumberOfCurrentPlayers(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamNumberOfCurrentPlayers"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamNumberOfCurrentPlayers"/>.</returns>
        public static SteamNumberOfCurrentPlayers Parse(JObject obj)
        {
            return obj == null ? null : new SteamNumberOfCurrentPlayers(obj);
        }

        #endregion

    }
}
