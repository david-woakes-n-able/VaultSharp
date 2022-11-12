using System.Collections.Generic;
using Newtonsoft.Json;

namespace VaultSharp.V1.SecretsEngines.PKI
{
    /// <summary>
    /// Represents a Certificate.
    /// </summary>
    public class IssuerData : AbstractCertificateData
    {
        /// <summary>
        /// CA chain for certificate
        /// </summary>
        /// <value>
        /// Certificate chain with certificates in PEM format
        /// </value>
        [JsonProperty("ca_chain")]
        public IEnumerable<string> CaChain { get; set; }

        /// <summary>
        /// List of urls to retries CRLs
        /// </summary>
        /// <value>
        /// </value>
        [JsonProperty("crl_distribution_points")]
        public IEnumerable<string> CrlDistributionPoints { get; set; }
        
        /// <summary>
        /// Issuer id (serial number) of issuer
        /// </summary>
        /// <value>
        /// </value>
        [JsonProperty("issuer_id")]
        public string IssuerId { get; set; }

        /// <summary>
        /// Issuer name if specified on creation
        /// </summary>
        [JsonProperty("issuer_name")]
        public string IssuerName { get; set; }
        
        /// <summary>
        /// Certificate chain in PEM format
        /// </summary>
        [JsonProperty("issuing_certificates")]
        public IEnumerable<string> IssuingCertificates { get; set; }

        /// <summary>
        /// Key id for this issuers certificate
        /// </summary>
        [JsonProperty("key_id")]
        public string KeyId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("leaf_not_after_behavior")]
        public string LeafNotAfterBehavior { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("manual_chain")]
        public IEnumerable<string>  ManualChain { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("oscp_servers")]
        public IEnumerable<string>  OscpServers { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("revocation_signature_algorithm")]
        public string RevocationSignatureAlgorithm { get; set; }
        
        /// <summary>
        /// Flag which indicates if the certificate has been revoked
        /// </summary>
        /// <value>
        /// true if issuer certificate has been revoked
        /// </value>
        [JsonProperty("revoked")]
        public bool Revoked { get; set; }
        
        /// <summary>
        /// CSV list containing one or more of crl-signing,
        /// issuing-certificates, ocsp-signing, read-only
        /// </summary>
        [JsonProperty("usage")]
        public string Usage { get; set; }
    }
}