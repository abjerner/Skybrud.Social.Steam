using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json.Extensions;

namespace Skybrud.Social.Steam.Models.User
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing player summaries as returned by the Steam api.
    /// </summary>
    public class SteamPlayerSummaries : SteamObject
    {

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        public SteamPlayerSummary[] PlayerSummaries { get; }

        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamPlayerSummaries(JObject obj) : base(obj)
        {
            PlayerSummaries = obj.GetObject("response").GetArray("players", SteamPlayerSummary.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamPlayerSummaries"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamPlayerSummaries"/>.</returns>
        public static SteamPlayerSummaries Parse(JObject obj)
        {
            return obj == null ? null : new SteamPlayerSummaries(obj);
        }

        #endregion

    }
}
