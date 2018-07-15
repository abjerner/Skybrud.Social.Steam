using Skybrud.Social.Steam.Endpoints.Raw;
using Skybrud.Social.Steam.Responses.Envoy;

namespace Skybrud.Social.Steam.Endpoints
{
    /// <summary>
    /// Implementation of the Steam envoy endpoint.
    /// </summary>
    public class SteamEnvoyEndpoint
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the Steam service.
        /// </summary>
        public SteamService Service { get; }

        /// <summary>
        /// Gets a reference to the raw endpoint.
        /// </summary>
        public SteamEnvoyRawEndpoint Raw => Service.Client.Envoy;

        #endregion

        #region Constructors

        internal SteamEnvoyEndpoint(SteamService service)
        {
            Service = service;
        }

        #endregion

        #region Methods

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SteamPaymentOutReverseNotificationResponse PaymentOutReversalNotification()
        {
            return SteamPaymentOutReverseNotificationResponse.ParseResponse(Raw.PaymentOutReversalNotification());
        }

        #endregion

    }
}
