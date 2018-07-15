using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.UserStats
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing player achievements as returned by the Steam api.
    /// </summary>
    public class SteamPlayerAchievements : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamPlayerAchievements(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamPlayerAchievements"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamPlayerAchievements"/>.</returns>
        public static SteamPlayerAchievements Parse(JObject obj)
        {
            return obj == null ? null : new SteamPlayerAchievements(obj);
        }

        #endregion

    }
}
