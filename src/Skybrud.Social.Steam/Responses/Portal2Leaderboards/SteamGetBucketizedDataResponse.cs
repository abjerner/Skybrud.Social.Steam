using System;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Models.Portal2Leaderboard;

namespace Skybrud.Social.Steam.Responses.Portal2Leaderboards
{
    /// <summary>
    /// Class representing the response of a call to get bucketized data.
    /// </summary>
    public class SteamGetBucketizedDataResponse : SteamResponse<SteamBucketizedData>
    {

        #region Constructors

        private SteamGetBucketizedDataResponse(SocialHttpResponse response) : base(response)
        {
            // Validate the response
            ValidateResponse(response);

            // Parse the response body
            Body = ParseJsonObject(response.Body, SteamBucketizedData.Parse);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>response</code> into an instance of <see cref="SteamGetBucketizedDataResponse"/>.
        /// </summary>
        /// <param name="response">The response to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamGetBucketizedDataResponse"/>.</returns>
        public static SteamGetBucketizedDataResponse ParseResponse(SocialHttpResponse response)
        {
            // Some validation
            if (response == null) throw new ArgumentNullException(nameof(response));

            // Initialize the response
            return new SteamGetBucketizedDataResponse(response);
        }

        #endregion

    }
}
