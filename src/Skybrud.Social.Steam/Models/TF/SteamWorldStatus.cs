using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.TF
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing world status as returned by the Steam api.
    /// </summary>
    public class SteamWorldStatus : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamWorldStatus(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamWorldStatus"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamWorldStatus"/>.</returns>
        public static SteamWorldStatus Parse(JObject obj)
        {
            return obj == null ? null : new SteamWorldStatus(obj);
        }

        #endregion

    }
}
