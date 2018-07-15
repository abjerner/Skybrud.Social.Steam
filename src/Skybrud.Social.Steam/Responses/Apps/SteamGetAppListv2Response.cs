using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.Apps;

namespace Skybrud.Social.Steam.Responses.Apps
{
    /// <summary>
    /// Class representing the response of a call to get a list of apps.
    /// </summary>
    public class SteamGetAppListv2Response : SteamResponse<SteamApps>
    {

        #region Constructors

        private SteamGetAppListv2Response(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamApps.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetAppListv2Response"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetAppListv2Response"/>.</returns>
        public static SteamGetAppListv2Response ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetAppListv2Response(response);
        }

        #endregion

    }
}
