using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.News;

namespace Skybrud.Social.Steam.Responses.News
{
    /// <summary>
    /// Class representing the response of a call to get the news for an app.
    /// </summary>
    public class SteamGetNewsForAppv2Response : SteamResponse<SteamAppNews>
    {

        #region Constructors

        private SteamGetNewsForAppv2Response(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamAppNews.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetNewsForAppv2Response"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetNewsForAppv2Response"/>.</returns>
        public static SteamGetNewsForAppv2Response ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetNewsForAppv2Response(response);
        }

        #endregion

    }
}
