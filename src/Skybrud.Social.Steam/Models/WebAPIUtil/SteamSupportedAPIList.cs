using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.WebAPIUtil
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing Steam supported api list as returned by the Steam api.
    /// </summary>
    public class SteamSupportedAPIList : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamSupportedAPIList(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamSupportedAPIList"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamSupportedAPIList"/>.</returns>
        public static SteamSupportedAPIList Parse(JObject obj)
        {
            return obj == null ? null : new SteamSupportedAPIList(obj);
        }

        #endregion

    }
}
