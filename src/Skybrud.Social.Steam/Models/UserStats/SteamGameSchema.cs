using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.UserStats
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing game schema as returned by the Steam api.
    /// </summary>
    public class SteamGameSchema : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamGameSchema(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamGameSchema"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGameSchema"/>.</returns>
        public static SteamGameSchema Parse(JObject obj)
        {
            return obj == null ? null : new SteamGameSchema(obj);
        }

        #endregion

    }
}
