﻿using Newtonsoft.Json.Linq;

namespace Skybrud.Social.Steam.Models.Directory
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing Steam cs servers as returned by the Steam api.
    /// </summary>
    public class SteamCSServers : SteamObject
    {

        #region Properties



        #endregion

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance based on the specified <code>obj</code>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> representing the object.</param>
        private SteamCSServers(JObject obj) : base(obj)
        {

        }

        #endregion

        #region Methods

        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamCSServers"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamCSServers"/>.</returns>
        public static SteamCSServers Parse(JObject obj)
        {
            return obj == null ? null : new SteamCSServers(obj);
        }

        #endregion

    }
}
