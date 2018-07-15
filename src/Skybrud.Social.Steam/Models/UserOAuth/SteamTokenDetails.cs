using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.UserOAuth
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing Steam token details as returned by the Steam api.
    /// </summary>
    public class SteamTokenDetails : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamTokenDetails(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamTokenDetails"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamTokenDetails"/>.</returns>
        public static SteamTokenDetails Parse(JObject obj)
        {
            return obj == null ? null : new SteamTokenDetails(obj);
        }

        #endregion

    }
}
