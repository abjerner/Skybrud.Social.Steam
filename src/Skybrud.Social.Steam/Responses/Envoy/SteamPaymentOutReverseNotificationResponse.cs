using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.Envoy;

namespace Skybrud.Social.Steam.Responses.Envoy
{
    /// <summary>
    /// Class representing the response of a call to post a payment out notification.
    /// </summary>
    public class SteamPaymentOutReverseNotificationResponse : SteamResponse<SteamPaymentOutReverseNotification>
    {

        #region Constructors

        private SteamPaymentOutReverseNotificationResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamPaymentOutReverseNotification.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamPaymentOutReverseNotificationResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamPaymentOutReverseNotificationResponse"/>.</returns>
        public static SteamPaymentOutReverseNotificationResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamPaymentOutReverseNotificationResponse(response);
        }

        #endregion

    }
}
