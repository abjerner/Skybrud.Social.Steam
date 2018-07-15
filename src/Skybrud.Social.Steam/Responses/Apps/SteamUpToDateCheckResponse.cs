using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.Apps;

namespace Skybrud.Social.Steam.Responses.Apps
{
    /// <summary>
    /// Class representing the response of a call to check if an app is up to date.
    /// </summary>
    public class SteamUpToDateCheckResponse : SteamResponse<SteamUpToDateCheck>
    {

        #region Constructors

        private SteamUpToDateCheckResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamUpToDateCheck.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamUpToDateCheckResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamUpToDateCheckResponse"/>.</returns>
        public static SteamUpToDateCheckResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamUpToDateCheckResponse(response);
        }

        #endregion

    }
}
