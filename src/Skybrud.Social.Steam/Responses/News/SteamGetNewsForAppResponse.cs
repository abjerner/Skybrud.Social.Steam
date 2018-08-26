using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.News;

namespace Skybrud.Social.Steam.Responses.News {
    
    /// <summary>
    /// Class representing the response of a request to get the news for an app.
    /// </summary>
    public class SteamGetNewsForAppResponse : SteamResponse<SteamNewsEnvelope> {

        #region Constructors

        private SteamGetNewsForAppResponse(SocialHttpResponse response) : base(response) {
            ValidateResponse(response);
            Body = ParseJsonObject(response.Body, SteamNewsEnvelope.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <paramref name="response"/> into an instance of <see cref="SteamGetNewsForAppResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>An instance of <see cref="SteamGetNewsForAppResponse"/>.</returns>
        public static SteamGetNewsForAppResponse ParseResponse(SocialHttpResponse response) {
            if (response == null) throw new ArgumentNullException(nameof(response));
            return new SteamGetNewsForAppResponse(response);
        }

        #endregion

    }

}