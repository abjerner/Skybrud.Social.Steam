using System.Net;
using Skybrud.Essentials.Json.Extensions;
using Skybrud.Social.Http;
using Skybrud.Social.Steam.Exceptions;

namespace Skybrud.Social.Steam.Responses
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing the response from the Steam api.
    /// </summary>
    public class SteamResponse : SocialResponse
    {

        #region Constructors

        protected SteamResponse(SocialHttpResponse response) : base(response) { }

        #endregion

        #region Methods

        /// <summary>
        /// Validates the specified <code>response</code>.
        /// </summary>
        /// <param name="response">The response to be validated.</param>
        public static void ValidateResponse(SocialHttpResponse response)
        {
            // Skip error checking if the server responds with an OK status code
            if (response.StatusCode == HttpStatusCode.OK) return;

            var obj = ParseJsonObject(response.Body);

            // For some types of errors, Steam will only respond with as error message
            if (obj.HasValue("error"))
            {
                throw new SteamException(response, obj.GetString("error"), 0);
            }

            // However in most cases, Steam responds with an array of errors
            var errors = obj.GetArray("errors");

            // Get the first error (don't remember ever seeing multiple errors in the same response)
            var error = errors.GetObject(0);

            // Throw the exception
            throw new SteamException(response, error.GetString("message"), error.GetInt32("code"));
        }

        #endregion

    }


    public class SteamResponse<T> : SteamResponse
    {

        #region Properties

        /// <summary>
        /// Gets the body of the response.
        /// </summary>
        public T Body { get; protected set; }

        #endregion

        #region Constructors

        protected SteamResponse(SocialHttpResponse response) : base(response) { }

        #endregion

    }
}
