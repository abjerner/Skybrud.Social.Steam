using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.GameNotification;

namespace Skybrud.Social.Steam.Responses.GameNotification
{
    /// <summary>
    /// Class representing the response of a call to update a user session.
    /// </summary>
    public class SteamUserUpdateSessionResponse : SteamResponse<SteamUserUpdatedSession>
    {

        #region Constructors

        private SteamUserUpdateSessionResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamUserUpdatedSession.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamUserUpdateSessionResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamUserUpdateSessionResponse"/>.</returns>
        public static SteamUserUpdateSessionResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamUserUpdateSessionResponse(response);
        }

        #endregion

    }
}
