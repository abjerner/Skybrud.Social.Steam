using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.WebUserPresenceOAuth
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing poll status as returned by the Steam api.
    /// </summary>
    public class SteamPollStatus : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamPollStatus(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamPollStatus"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamPollStatus"/>.</returns>
        public static SteamPollStatus Parse(JObject obj)
        {
            return obj == null ? null : new SteamPollStatus(obj);
        }

        #endregion

    }
}
