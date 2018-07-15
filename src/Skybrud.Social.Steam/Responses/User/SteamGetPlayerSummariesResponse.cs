using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.User;

namespace Skybrud.Social.Steam.Responses.User
{
    /// <summary>
    /// Class representing the response of a call to get the summaries for players.
    /// </summary>
    public class SteamGetPlayerSummariesResponse : SteamResponse<SteamPlayerSummaries>
    {

        #region Constructors

        private SteamGetPlayerSummariesResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamPlayerSummaries.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetPlayerSummariesResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetPlayerSummariesResponse"/>.</returns>
        public static SteamGetPlayerSummariesResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetPlayerSummariesResponse(response);
        }

        #endregion

    }
}
