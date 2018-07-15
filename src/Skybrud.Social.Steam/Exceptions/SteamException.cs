using System;
using Skybrud.Social.Http;

namespace Skybrud.Social.Steam.Exceptions
{
    public class SteamException : Exception
    {

        #region Properties

        /// <summary>
        /// Gets a reference to the underlying <see cref="SocialHttpResponse"/>
        /// </summary>
        public SocialHttpResponse Response { get; }

        /// <summary>
        /// Gets the error code received from the Steam api.
        /// </summary>
        public int Code { get; }

        #endregion

        #region Constructors

        internal SteamException(SocialHttpResponse response, string message) : base(message)
        {
            Response = response;
        }

        internal SteamException(SocialHttpResponse response, string message, int code) : base(message)
        {
            Response = response;
            Code = code;
        }

        #endregion

    }
}
