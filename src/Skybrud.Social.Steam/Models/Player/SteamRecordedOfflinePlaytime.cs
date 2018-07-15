using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.Player
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing recorded offline playtime as returned by the Steam api.
    /// </summary>
    public class SteamRecordedOfflinePlaytime : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamRecordedOfflinePlaytime(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamRecordedOfflinePlaytime"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamRecordedOfflinePlaytime"/>.</returns>
        public static SteamRecordedOfflinePlaytime Parse(JObject obj)
        {
            return obj == null ? null : new SteamRecordedOfflinePlaytime(obj);
        }

        #endregion

    }
}
