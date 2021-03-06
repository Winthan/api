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
    /// TradingPermissionsResponse
    /// </summary>
    [DataContract]
    public partial class TradingPermissionsResponse :  IEquatable<TradingPermissionsResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradingPermissionsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TradingPermissionsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TradingPermissionsResponse" /> class.
        /// </summary>
        /// <param name="TradingPermissions">TradingPermissions (required).</param>
        public TradingPermissionsResponse(List<TradingPermission> TradingPermissions = null)
        {
            // to ensure "TradingPermissions" is required (not null)
            if (TradingPermissions == null)
            {
                throw new InvalidDataException("TradingPermissions is a required property for TradingPermissionsResponse and cannot be null");
            }
            else
            {
                this.TradingPermissions = TradingPermissions;
            }
        }
        
        /// <summary>
        /// Gets or Sets TradingPermissions
        /// </summary>
        [DataMember(Name="tradingPermissions", EmitDefaultValue=false)]
        public List<TradingPermission> TradingPermissions { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TradingPermissionsResponse {\n");
            sb.Append("  TradingPermissions: ").Append(TradingPermissions).Append("\n");
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
            return this.Equals(obj as TradingPermissionsResponse);
        }

        /// <summary>
        /// Returns true if TradingPermissionsResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TradingPermissionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradingPermissionsResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TradingPermissions == other.TradingPermissions ||
                    this.TradingPermissions != null &&
                    this.TradingPermissions.SequenceEqual(other.TradingPermissions)
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
                if (this.TradingPermissions != null)
                    hash = hash * 59 + this.TradingPermissions.GetHashCode();
                return hash;
            }
        }
    }

}
