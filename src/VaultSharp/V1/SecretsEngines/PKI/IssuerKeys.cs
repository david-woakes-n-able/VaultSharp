using System.Collections.Generic;
using Newtonsoft.Json;

namespace VaultSharp.V1.SecretsEngines.PKI
{
    public class IssuerInfo
    {
        /// <summary>
        /// Gets or sets default issuer flag
        /// </summary>
        /// <value>
        /// True if this is the default certificate used to issue certificates
        /// </value>
        [JsonProperty("is_default")]
        public bool IsDefault { get;set; }

        /// <summary>
        /// Gets or sets issuer name
        /// </summary>
        /// <value>
        /// Issuer name if set
        /// </value>
        [JsonProperty("issuer_name")]
        public string IssuerName { get;set; }
    }

    /// <summary>
    /// Vault Response Model containing list of certificate keys (serial numbers)
    /// </summary>
    public class IssuerKeys
    {
        [JsonProperty("key_info")]
        public Dictionary<string, IssuerInfo> KeyInfo { get; set; }
        /// <summary>
        /// Gets or sets list of certificate keys (serial numbers)
        /// </summary>
        /// <value>
        /// List of certificate keys (serial numbers)
        /// </value>
        [JsonProperty("keys")]
        public List<string> Keys { get; set; }
    }
}