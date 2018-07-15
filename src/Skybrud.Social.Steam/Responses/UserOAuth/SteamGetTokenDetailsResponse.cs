using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.UserOAuth;

namespace Skybrud.Social.Steam.Responses.UserOAuth
{
    /// <summary>
    /// Class representing the response of a call to get the details of a token.
    /// </summary>
    public class SteamGetTokenDetailsResponse : SteamResponse<SteamTokenDetails>
    {

        #region Constructors

        private SteamGetTokenDetailsResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamTokenDetails.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetTokenDetailsResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetTokenDetailsResponse"/>.</returns>
        public static SteamGetTokenDetailsResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetTokenDetailsResponse(response);
        }

        #endregion

    }
}
