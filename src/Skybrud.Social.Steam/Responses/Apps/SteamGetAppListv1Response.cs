using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.Apps;

namespace Skybrud.Social.Steam.Responses.Apps
{
    /// <summary>
    /// Class representing the response of a call to get a list of apps.
    /// </summary>
    public class SteamGetAppListv1Response : SteamResponse<SteamApps>
    {

        #region Constructors

        private SteamGetAppListv1Response(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamApps.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetAppListv1Response"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetAppListv1Response"/>.</returns>
        public static SteamGetAppListv1Response ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetAppListv1Response(response);
        }

        #endregion

    }
}
