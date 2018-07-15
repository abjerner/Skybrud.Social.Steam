using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.UserAuth;

namespace Skybrud.Social.Steam.Responses.UserAuth
{
    /// <summary>
    /// Class representing the response of a call to authenticate a user.
    /// </summary>
    public class SteamAuthenticateUserResponse : SteamResponse<SteamAuthenticatedUser>
    {

        #region Constructors

        private SteamAuthenticateUserResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamAuthenticatedUser.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamAuthenticateUserResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamAuthenticateUserResponse"/>.</returns>
        public static SteamAuthenticateUserResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamAuthenticateUserResponse(response);
        }

        #endregion

    }
}
