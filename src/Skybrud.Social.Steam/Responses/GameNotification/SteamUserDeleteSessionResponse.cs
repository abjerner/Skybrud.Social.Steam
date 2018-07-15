using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.GameNotification;

namespace Skybrud.Social.Steam.Responses.GameNotification
{
    /// <summary>
    /// Class representing the response of a call to delete a user session.
    /// </summary>
    public class SteamUserDeleteSessionResponse : SteamResponse<SteamUserDeletedSession>
    {

        #region Constructors

        private SteamUserDeleteSessionResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamUserDeletedSession.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamUserDeleteSessionResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamUserDeleteSessionResponse"/>.</returns>
        public static SteamUserDeleteSessionResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamUserDeleteSessionResponse(response);
        }

        #endregion

    }
}
