using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.WebAPIUtil;

namespace Skybrud.Social.Steam.Responses.WebAPIUtil
{
    /// <summary>
    /// Class representing the response of a call to get server info.
    /// </summary>
    public class SteamGetServerInfoResponse : SteamResponse<SteamServerInfo>
    {

        #region Constructors

        private SteamGetServerInfoResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamServerInfo.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetServerInfoResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetServerInfoResponse"/>.</returns>
        public static SteamGetServerInfoResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetServerInfoResponse(response);
        }

        #endregion

    }
}
