using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.UserStats;

namespace Skybrud.Social.Steam.Responses.UserStats
{
    /// <summary>
    /// Class representing the response of a call to get the schema for a game.
    /// </summary>
    public class SteamGetSchemaForGameResponse : SteamResponse<SteamGameSchema>
    {

        #region Constructors

        private SteamGetSchemaForGameResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamGameSchema.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetSchemaForGameResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetSchemaForGameResponse"/>.</returns>
        public static SteamGetSchemaForGameResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetSchemaForGameResponse(response);
        }

        #endregion

    }
}
