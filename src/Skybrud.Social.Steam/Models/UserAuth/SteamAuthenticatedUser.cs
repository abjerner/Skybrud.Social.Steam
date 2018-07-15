using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.UserAuth
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing authenticated user as returned by the Steam api.
    /// </summary>
    public class SteamAuthenticatedUser : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamAuthenticatedUser(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamAuthenticatedUser"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamAuthenticatedUser"/>.</returns>
        public static SteamAuthenticatedUser Parse(JObject obj)
        {
            return obj == null ? null : new SteamAuthenticatedUser(obj);
        }

        #endregion

    }
}
