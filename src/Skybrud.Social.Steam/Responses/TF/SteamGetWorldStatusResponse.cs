using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.TF;

namespace Skybrud.Social.Steam.Responses.TF
{
    /// <summary>
    /// Class representing the response of a call to get the status of the world.
    /// </summary>
    public class SteamGetWorldStatusResponse : SteamResponse<SteamWorldStatus>
    {

        #region Constructors

        private SteamGetWorldStatusResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamWorldStatus.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetWorldStatusResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetWorldStatusResponse"/>.</returns>
        public static SteamGetWorldStatusResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetWorldStatusResponse(response);
        }

        #endregion

    }
}
