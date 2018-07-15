using Newtonsoft.Json.Linq;
using Skybrud.Essentials.Json;

namespace Skybrud.Social.Steam.Models
{
    /// <inheritdoc />
    /// <summary>
    /// Class representing a basic object from the Steam api derived from an instance of <see cref="T:Newtonsoft.Json.Linq.JObject" />.
    /// </summary>
    public class SteamObject : JsonObjectBase
    {

        #region Constructors

        /// <inheritdoc />
        /// <summary>
        /// Parses the specified <code>obj</code> into an instance of <see cref="SteamObject"/>.
        /// </summary>
        /// <param name="obj">The instance of <see cref="JObject"/> to be parsed.</param>
        /// <returns>Returns an instance of <see cref="SteamObject"/>.</returns>
        protected SteamObject(JObject obj) : base(obj) { }

        #endregion

        #region Methods

        /// <summary>
        /// Gets whether the underlying json object has a property with the specified <see cref="propertyName"/>.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        /// <returns>Returns <code>true</code> if the property exists, otherwise <code>false</code>.</returns>
        protected bool HasJsonProperty(string propertyName)
        {
            return JObject?.Property(propertyName) != null;
        }

        #endregion

    }
}
