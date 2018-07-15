using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.Player;

namespace Skybrud.Social.Steam.Responses.Player
{
    /// <summary>
    /// Class representing the response of a call to get the owned games of a user.
    /// </summary>
    public class SteamGetOwnedGamesResponse : SteamResponse<SteamOwnedGames>
    {

        #region Constructors

        private SteamGetOwnedGamesResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamOwnedGames.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetOwnedGamesResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetOwnedGamesResponse"/>.</returns>
        public static SteamGetOwnedGamesResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetOwnedGamesResponse(response);
        }

        #endregion

    }
}
