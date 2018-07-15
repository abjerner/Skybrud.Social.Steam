using Skybrud.Social.Http;
using Skybrud.Social.Interfaces.Http;

namespace Skybrud.Social.Steam.Options.AccountRecovery
{
    /// <inheritdoc />
    /// <summary>
    /// Options for a call to the Steam api for sending account recovery data.
    /// </summary>
    public class SteamReportAccountRecoveryDataOptions : IHttpPostOptions
    {

        #region Properties

        /// <summary>
        /// Gets or sets the login user list.
        /// </summary>
        public string LoginUserList { get; set; }

        /// <summary>
        /// Gets or sets the install config.
        /// </summary>
        public string InstallConfig { get; set; }

        /// <summary>
        /// Gets or sets the sha sentry file.
        /// </summary>
        public string ShaSentryFile { get; set; }

        /// <summary>
        /// Gets or sets the machine id.
        /// </summary>
        public string MachineId { get; set; }

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
                {"loginuser_list", LoginUserList},
                {"install_config", InstallConfig},
                {"shasentryfile", ShaSentryFile},
                {"machineid", MachineId}
            };
            return data;
        }

        #endregion

    }
}
