/* 
 * API
 *
 * API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: you@your-company.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Telestream.Cloud.Stores.Client.SwaggerDateConverter;

namespace Telestream.Cloud.Stores.Model
{
    /// <summary>
    /// StoreBodyProviderSpecificSettings
    /// </summary>
    [DataContract]
    public partial class StoreBodyProviderSpecificSettings :  IEquatable<StoreBodyProviderSpecificSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoreBodyProviderSpecificSettings" /> class.
        /// </summary>
        /// <param name="Host">Host.</param>
        /// <param name="Port">Port.</param>
        /// <param name="CacheControl">CacheControl.</param>
        /// <param name="Metadata">Metadata.</param>
        /// <param name="FaspPort">FaspPort.</param>
        /// <param name="SshPort">SshPort.</param>
        /// <param name="MaxRate">MaxRate.</param>
        /// <param name="MinRate">MinRate.</param>
        /// <param name="Policy">Policy.</param>
        public StoreBodyProviderSpecificSettings(string Host = default(string), string Port = default(string), string CacheControl = default(string), string Metadata = default(string), string FaspPort = default(string), string SshPort = default(string), string MaxRate = default(string), string MinRate = default(string), string Policy = default(string))
        {
            this.Host = Host;
            this.Port = Port;
            this.CacheControl = CacheControl;
            this.Metadata = Metadata;
            this.FaspPort = FaspPort;
            this.SshPort = SshPort;
            this.MaxRate = MaxRate;
            this.MinRate = MinRate;
            this.Policy = Policy;
        }
        
        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name="host", EmitDefaultValue=false)]
        public string Host { get; set; }

        /// <summary>
        /// Gets or Sets Port
        /// </summary>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public string Port { get; set; }

        /// <summary>
        /// Gets or Sets CacheControl
        /// </summary>
        [DataMember(Name="cache_control", EmitDefaultValue=false)]
        public string CacheControl { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// Gets or Sets FaspPort
        /// </summary>
        [DataMember(Name="fasp_port", EmitDefaultValue=false)]
        public string FaspPort { get; set; }

        /// <summary>
        /// Gets or Sets SshPort
        /// </summary>
        [DataMember(Name="ssh_port", EmitDefaultValue=false)]
        public string SshPort { get; set; }

        /// <summary>
        /// Gets or Sets MaxRate
        /// </summary>
        [DataMember(Name="max_rate", EmitDefaultValue=false)]
        public string MaxRate { get; set; }

        /// <summary>
        /// Gets or Sets MinRate
        /// </summary>
        [DataMember(Name="min_rate", EmitDefaultValue=false)]
        public string MinRate { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name="policy", EmitDefaultValue=false)]
        public string Policy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoreBodyProviderSpecificSettings {\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  CacheControl: ").Append(CacheControl).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  FaspPort: ").Append(FaspPort).Append("\n");
            sb.Append("  SshPort: ").Append(SshPort).Append("\n");
            sb.Append("  MaxRate: ").Append(MaxRate).Append("\n");
            sb.Append("  MinRate: ").Append(MinRate).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as StoreBodyProviderSpecificSettings);
        }

        /// <summary>
        /// Returns true if StoreBodyProviderSpecificSettings instances are equal
        /// </summary>
        /// <param name="input">Instance of StoreBodyProviderSpecificSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoreBodyProviderSpecificSettings input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.CacheControl == input.CacheControl ||
                    (this.CacheControl != null &&
                    this.CacheControl.Equals(input.CacheControl))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.FaspPort == input.FaspPort ||
                    (this.FaspPort != null &&
                    this.FaspPort.Equals(input.FaspPort))
                ) && 
                (
                    this.SshPort == input.SshPort ||
                    (this.SshPort != null &&
                    this.SshPort.Equals(input.SshPort))
                ) && 
                (
                    this.MaxRate == input.MaxRate ||
                    (this.MaxRate != null &&
                    this.MaxRate.Equals(input.MaxRate))
                ) && 
                (
                    this.MinRate == input.MinRate ||
                    (this.MinRate != null &&
                    this.MinRate.Equals(input.MinRate))
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Host != null)
                    hashCode = hashCode * 59 + this.Host.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.CacheControl != null)
                    hashCode = hashCode * 59 + this.CacheControl.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.FaspPort != null)
                    hashCode = hashCode * 59 + this.FaspPort.GetHashCode();
                if (this.SshPort != null)
                    hashCode = hashCode * 59 + this.SshPort.GetHashCode();
                if (this.MaxRate != null)
                    hashCode = hashCode * 59 + this.MaxRate.GetHashCode();
                if (this.MinRate != null)
                    hashCode = hashCode * 59 + this.MinRate.GetHashCode();
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                return hashCode;
            }
        }
    }

}
