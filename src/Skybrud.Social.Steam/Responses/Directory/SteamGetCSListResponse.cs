using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.Directory;

namespace Skybrud.Social.Steam.Responses.Directory
{
    /// <summary>
    /// Class representing the response of a call to get a list of cs servers.
    /// </summary>
    public class SteamGetCSListResponse : SteamResponse<SteamCSServers>
    {

        #region Constructors

        private SteamGetCSListResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamCSServers.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetCSListResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetCSListResponse"/>.</returns>
        public static SteamGetCSListResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetCSListResponse(response);
        }

        #endregion

    }
}
