using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.WebAPIUtil;

namespace Skybrud.Social.Steam.Responses.WebAPIUtil
{
    /// <summary>
    /// Class representing the response of a call to get the supported api list.
    /// </summary>
    public class SteamGetSupportedAPIListResponse : SteamResponse<SteamSupportedAPIList>
    {

        #region Constructors

        private SteamGetSupportedAPIListResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamSupportedAPIList.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetSupportedAPIListResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetSupportedAPIListResponse"/>.</returns>
        public static SteamGetSupportedAPIListResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetSupportedAPIListResponse(response);
        }

        #endregion

    }
}
