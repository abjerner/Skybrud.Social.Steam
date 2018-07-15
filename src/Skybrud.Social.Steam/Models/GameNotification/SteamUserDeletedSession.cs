using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.GameNotification
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing user deleted session as returned by the Steam api.
    /// </summary>
    public class SteamUserDeletedSession : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamUserDeletedSession(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamUserDeletedSession"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamUserDeletedSession"/>.</returns>
        public static SteamUserDeletedSession Parse(JObject obj)
        {
            return obj == null ? null : new SteamUserDeletedSession(obj);
        }

        #endregion

    }
}
