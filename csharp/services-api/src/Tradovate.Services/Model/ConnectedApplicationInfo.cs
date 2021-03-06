/* 
 * Tradovate API
 *
 * Tradovate API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
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

namespace Tradovate.Services.Model
{
    /// <summary>
    /// ConnectedApplicationInfo
    /// </summary>
    [DataContract]
    public partial class ConnectedApplicationInfo :  IEquatable<ConnectedApplicationInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectedApplicationInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectedApplicationInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectedApplicationInfo" /> class.
        /// </summary>
        /// <param name="StartTime">StartTime (required).</param>
        /// <param name="AppId">AppId (required).</param>
        /// <param name="UserAgent">UserAgent (required).</param>
        /// <param name="DeviceId">DeviceId (required).</param>
        /// <param name="IpAddress">IpAddress (required).</param>
        public ConnectedApplicationInfo(DateTime? StartTime = null, string AppId = null, string UserAgent = null, string DeviceId = null, string IpAddress = null)
        {
            // to ensure "StartTime" is required (not null)
            if (StartTime == null)
            {
                throw new InvalidDataException("StartTime is a required property for ConnectedApplicationInfo and cannot be null");
            }
            else
            {
                this.StartTime = StartTime;
            }
            // to ensure "AppId" is required (not null)
            if (AppId == null)
            {
                throw new InvalidDataException("AppId is a required property for ConnectedApplicationInfo and cannot be null");
            }
            else
            {
                this.AppId = AppId;
            }
            // to ensure "UserAgent" is required (not null)
            if (UserAgent == null)
            {
                throw new InvalidDataException("UserAgent is a required property for ConnectedApplicationInfo and cannot be null");
            }
            else
            {
                this.UserAgent = UserAgent;
            }
            // to ensure "DeviceId" is required (not null)
            if (DeviceId == null)
            {
                throw new InvalidDataException("DeviceId is a required property for ConnectedApplicationInfo and cannot be null");
            }
            else
            {
                this.DeviceId = DeviceId;
            }
            // to ensure "IpAddress" is required (not null)
            if (IpAddress == null)
            {
                throw new InvalidDataException("IpAddress is a required property for ConnectedApplicationInfo and cannot be null");
            }
            else
            {
                this.IpAddress = IpAddress;
            }
        }
        
        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }
        /// <summary>
        /// Gets or Sets AppId
        /// </summary>
        [DataMember(Name="appId", EmitDefaultValue=false)]
        public string AppId { get; set; }
        /// <summary>
        /// Gets or Sets UserAgent
        /// </summary>
        [DataMember(Name="userAgent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }
        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name="deviceId", EmitDefaultValue=false)]
        public string DeviceId { get; set; }
        /// <summary>
        /// Gets or Sets IpAddress
        /// </summary>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectedApplicationInfo {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  AppId: ").Append(AppId).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ConnectedApplicationInfo);
        }

        /// <summary>
        /// Returns true if ConnectedApplicationInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectedApplicationInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectedApplicationInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.AppId == other.AppId ||
                    this.AppId != null &&
                    this.AppId.Equals(other.AppId)
                ) && 
                (
                    this.UserAgent == other.UserAgent ||
                    this.UserAgent != null &&
                    this.UserAgent.Equals(other.UserAgent)
                ) && 
                (
                    this.DeviceId == other.DeviceId ||
                    this.DeviceId != null &&
                    this.DeviceId.Equals(other.DeviceId)
                ) && 
                (
                    this.IpAddress == other.IpAddress ||
                    this.IpAddress != null &&
                    this.IpAddress.Equals(other.IpAddress)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                if (this.AppId != null)
                    hash = hash * 59 + this.AppId.GetHashCode();
                if (this.UserAgent != null)
                    hash = hash * 59 + this.UserAgent.GetHashCode();
                if (this.DeviceId != null)
                    hash = hash * 59 + this.DeviceId.GetHashCode();
                if (this.IpAddress != null)
                    hash = hash * 59 + this.IpAddress.GetHashCode();
                return hash;
            }
        }
    }

}
