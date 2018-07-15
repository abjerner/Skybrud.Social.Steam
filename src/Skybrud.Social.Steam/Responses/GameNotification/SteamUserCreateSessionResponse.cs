using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.GameNotification;

namespace Skybrud.Social.Steam.Responses.GameNotification
{
    /// <summary>
    /// Class representing the response of a call to create a user session.
    /// </summary>
    public class SteamUserCreateSessionResponse : SteamResponse<SteamUserCreatedSession>
    {

        #region Constructors

        private SteamUserCreateSessionResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamUserCreatedSession.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamUserCreateSessionResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamUserCreateSessionResponse"/>.</returns>
        public static SteamUserCreateSessionResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamUserCreateSessionResponse(response);
        }

        #endregion

    }
}
