using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.WebUserPresenceOAuth
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for setting the poll status.
    /// </summary>
    public class SteamPollStatusOptions : IHttpPostOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the 64 bit Steam id.
        /// </summary>
        public string SteamId { get; set; }

        /// <summary>
        /// Gets or sets the umq id.
        /// </summary>
        public ulong UmqId { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public uint Message { get; set; }

        /// <summary>
        /// Gets or sets the poll id.
        /// </summary>
        public uint? PollId { get; set; }

        /// <summary>
        /// Gets or sets the timeout in seconds.
        /// </summary>
        public uint? SecTimeout { get; set; }

        /// <summary>
        /// Gets or sets the idle time in seconds.
        /// </summary>
        public uint? SecIdleTime { get; set; }

        /// <summary>
        /// Gets or sets the account ids to use.
        /// </summary>
        public uint? UseAccountIds { get; set; }

        #endregion

        #region Methods

        public IHttpQueryString GetQueryString()
        {
            return null;
        }

        public IHttpPostData GetPostData()
        {
            var data = new SocialHttpPostData {{"steamid", SteamId}, {"umqid", UmqId}, {"message", Message}};
            if (PollId != null) data.Add("pollid", PollId);
            if (SecTimeout != null) data.Add("sectimeout", SecTimeout);
            if (SecIdleTime != null) data.Add("secidletime", SecIdleTime);
            if (UseAccountIds != null) data.Add("use_accountids", UseAccountIds);
            return data;
        }

        #endregion

    }
}
