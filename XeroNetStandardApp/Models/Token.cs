using System;

namespace XeroNetStandardApp.Models
{
    public class Token
    {
        /// <summary>
        /// Gets or sets the name of the client.
        /// </summary>
        /// <value>
        /// The name of the client.
        /// </value>
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>
        /// The location.
        /// </value>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the realm identifier.
        /// </summary>
        /// <value>
        /// The realm identifier.
        /// </value>
        public string RealmId { get; set; }

        /// <summary>
        /// Gets or sets the access token.
        /// </summary>
        /// <value>
        /// The access token.
        /// </value>
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or sets the access token expiry.
        /// </summary>
        /// <value>
        /// The access token expiry.
        /// </value>
        public DateTime? AccessTokenExpiry { get; set; }

        /// <summary>
        /// Gets or sets the refresh token.
        /// </summary>
        /// <value>
        /// The refresh token.
        /// </value>
        public string RefreshToken { get; set; }

        /// <summary>
        /// Gets or sets the refresh token expiry.
        /// </summary>
        /// <value>
        /// The refresh token expiry.
        /// </value>
        public DateTime? RefreshTokenExpiry { get; set; }
    }
}
