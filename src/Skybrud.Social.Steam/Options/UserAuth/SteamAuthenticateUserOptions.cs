using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.UserAuth
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for authenticating a user.
    /// </summary>
    public class SteamAuthenticateUserOptions : IHttpPostOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the 64 bit Steam id.
        /// </summary>
        public ulong SteamId { get; set; }

        /// <summary>
        /// Gets or sets the session key.
        /// </summary>
        public byte[] SessionKey { get; set; }

        /// <summary>
        /// Gets or sets the encrypted login key.
        /// </summary>
        public byte[] EncryptedLoginKey { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            return null;
        }

        public IHttpPostData GetPostData()
        {
            var data = new SocialHttpPostData
            {
                {"steamid", SteamId},
                {"sessionkey", SessionKey},
                {"encrypted_loginkey", EncryptedLoginKey}
            };
            return data;
        }

        #endregion

    }
}
