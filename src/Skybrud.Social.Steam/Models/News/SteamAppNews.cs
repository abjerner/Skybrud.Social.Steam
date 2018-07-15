using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.News
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing app news as returned by the Steam api.
    /// </summary>
    public class SteamAppNews : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamAppNews(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamAppNews"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamAppNews"/>.</returns>
        public static SteamAppNews Parse(JObject obj)
        {
            return obj == null ? null : new SteamAppNews(obj);
        }

        #endregion

    }
}
