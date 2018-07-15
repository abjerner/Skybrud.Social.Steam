using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.Player;

namespace Skybrud.Social.Steam.Responses.Player
{
    /// <summary>
    /// Class representing the response of a call to get the recently played games of a user.
    /// </summary>
    public class SteamGetRecentlyPlayedGamesResponse : SteamResponse<SteamRecentlyPlayedGames>
    {

        #region Constructors

        private SteamGetRecentlyPlayedGamesResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamRecentlyPlayedGames.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetRecentlyPlayedGamesResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetRecentlyPlayedGamesResponse"/>.</returns>
        public static SteamGetRecentlyPlayedGamesResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetRecentlyPlayedGamesResponse(response);
        }

        #endregion

    }
}
