using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.User
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing Steam friend list as returned by the Steam api.
    /// </summary>
    public class SteamFriendList : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamFriendList(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamFriendList"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamFriendList"/>.</returns>
        public static SteamFriendList Parse(JObject obj)
        {
            return obj == null ? null : new SteamFriendList(obj);
        }

        #endregion

    }
}
