using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.Directory;

namespace Skybrud.Social.Steam.Responses.Directory
{
    /// <summary>
    /// Class representing the response of a call to get a list of cm servers.
    /// </summary>
    public class SteamGetCMListResponse : SteamResponse<SteamCMServers>
    {

        #region Constructors

        private SteamGetCMListResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamCMServers.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetCMListResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetCMListResponse"/>.</returns>
        public static SteamGetCMListResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetCMListResponse(response);
        }

        #endregion

    }
}
