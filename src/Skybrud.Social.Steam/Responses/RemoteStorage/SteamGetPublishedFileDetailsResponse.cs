using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.RemoteStorage;

namespace Skybrud.Social.Steam.Responses.RemoteStorage
{
    /// <summary>
    /// Class representing the response of a call to get the details of a published file.
    /// </summary>
    public class SteamGetPublishedFileDetailsResponse : SteamResponse<SteamPublishedFileDetails>
    {

        #region Constructors

        private SteamGetPublishedFileDetailsResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamPublishedFileDetails.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetPublishedFileDetailsResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetPublishedFileDetailsResponse"/>.</returns>
        public static SteamGetPublishedFileDetailsResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetPublishedFileDetailsResponse(response);
        }

        #endregion

    }
}
