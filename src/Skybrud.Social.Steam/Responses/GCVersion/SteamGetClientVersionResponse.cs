using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.GCVersion;

namespace Skybrud.Social.Steam.Responses.GCVersion
{
    /// <summary>
    /// Class representing the response of a call to get the client version.
    /// </summary>
    public class SteamGetClientVersionResponse : SteamResponse<SteamClientVersion>
    {

        #region Constructors

        private SteamGetClientVersionResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamClientVersion.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetClientVersionResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetClientVersionResponse"/>.</returns>
        public static SteamGetClientVersionResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetClientVersionResponse(response);
        }

        #endregion

    }
}
