using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.Apps;

namespace Skybrud.Social.Steam.Responses.Apps
{
    /// <summary>
    /// Class representing the response of a call to get the servers at the address.
    /// </summary>
    public class SteamGetServersAtAddressResponse : SteamResponse<SteamServers>
    {

        #region Constructors

        private SteamGetServersAtAddressResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamServers.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetServersAtAddressResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetServersAtAddressResponse"/>.</returns>
        public static SteamGetServersAtAddressResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetServersAtAddressResponse(response);
        }

        #endregion

    }
}
