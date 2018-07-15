using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.GCVersion;

namespace Skybrud.Social.Steam.Responses.GCVersion
{
    /// <summary>
    /// Class representing the response of a call to get the server version.
    /// </summary>
    public class SteamGetServerVersionResponse : SteamResponse<SteamServerVersion>
    {

        #region Constructors

        private SteamGetServerVersionResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamServerVersion.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetServerVersionResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetServerVersionResponse"/>.</returns>
        public static SteamGetServerVersionResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetServerVersionResponse(response);
        }

        #endregion

    }
}
