using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.UserStats;

namespace Skybrud.Social.Steam.Responses.UserStats
{
    /// <summary>
    /// Class representing the response of a call to get the number of current players for a game.
    /// </summary>
    public class SteamGetNumberOfCurrentPlayersResponse : SteamResponse<SteamNumberOfCurrentPlayers>
    {

        #region Constructors

        private SteamGetNumberOfCurrentPlayersResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamNumberOfCurrentPlayers.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetNumberOfCurrentPlayersResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetNumberOfCurrentPlayersResponse"/>.</returns>
        public static SteamGetNumberOfCurrentPlayersResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetNumberOfCurrentPlayersResponse(response);
        }

        #endregion

    }
}
