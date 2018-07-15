using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.AccountRecovery
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing retrieve account recovery data as returned by the Steam api.
    /// </summary>
    public class SteamRetrieveAccountRecoveryData : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamRetrieveAccountRecoveryData(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamRetrieveAccountRecoveryData"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamRetrieveAccountRecoveryData"/>.</returns>
        public static SteamRetrieveAccountRecoveryData Parse(JObject obj)
        {
            return obj == null ? null : new SteamRetrieveAccountRecoveryData(obj);
        }

        #endregion

    }
}
