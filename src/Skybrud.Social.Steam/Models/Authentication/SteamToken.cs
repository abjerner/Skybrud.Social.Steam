using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Steam.Models.Authentication
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing an access token received from the Steam api.
    /// </summary>
    public class SteamToken : SteamObject
    {

        #region Properties

        /// <summary>
        /// Gets the access token.
        /// </summary>
        public string AccessToken { get; }

        #endregion

        #region Constructors

        private SteamToken(JObject obj) : base(obj)
        {
            AccessToken = obj.GetString("access_token");
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamToken"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamToken"/>.</returns>
        public static SteamToken Parse(JObject obj)
        {
            return obj == null ? null : new SteamToken(obj);
        }

        #endregion

    }
}
