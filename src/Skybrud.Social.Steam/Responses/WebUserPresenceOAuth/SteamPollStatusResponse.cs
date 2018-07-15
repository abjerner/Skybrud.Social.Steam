using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.WebUserPresenceOAuth;

namespace Skybrud.Social.Steam.Responses.WebUserPresenceOAuth
{
    /// <summary>
    /// Class representing the response of a call to set the poll status.
    /// </summary>
    public class SteamPollStatusResponse : SteamResponse<SteamPollStatus>
    {

        #region Constructors

        private SteamPollStatusResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamPollStatus.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamPollStatusResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamPollStatusResponse"/>.</returns>
        public static SteamPollStatusResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamPollStatusResponse(response);
        }

        #endregion

    }
}
