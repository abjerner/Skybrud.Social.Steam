using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.Envoy
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing payment out reverse notification as returned by the Steam api.
    /// </summary>
    public class SteamPaymentOutReverseNotification : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamPaymentOutReverseNotification(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamPaymentOutReverseNotification"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamPaymentOutReverseNotification"/>.</returns>
        public static SteamPaymentOutReverseNotification Parse(JObject obj)
        {
            return obj == null ? null : new SteamPaymentOutReverseNotification(obj);
        }

        #endregion

    }
}
