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
    /// CancelTradovateSubscription
    /// </summary>
    [DataContract]
    public partial class CancelTradovateSubscription :  IEquatable<CancelTradovateSubscription>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelTradovateSubscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CancelTradovateSubscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelTradovateSubscription" /> class.
        /// </summary>
        /// <param name="TradovateSubscriptionId">id of TradovateSubscription (required).</param>
        /// <param name="CancelReason">CancelReason.</param>
        public CancelTradovateSubscription(int? TradovateSubscriptionId = null, string CancelReason = null)
        {
            // to ensure "TradovateSubscriptionId" is required (not null)
            if (TradovateSubscriptionId == null)
            {
                throw new InvalidDataException("TradovateSubscriptionId is a required property for CancelTradovateSubscription and cannot be null");
            }
            else
            {
                this.TradovateSubscriptionId = TradovateSubscriptionId;
            }
            this.CancelReason = CancelReason;
        }
        
        /// <summary>
        /// id of TradovateSubscription
        /// </summary>
        /// <value>id of TradovateSubscription</value>
        [DataMember(Name="tradovateSubscriptionId", EmitDefaultValue=false)]
        public int? TradovateSubscriptionId { get; set; }
        /// <summary>
        /// Gets or Sets CancelReason
        /// </summary>
        [DataMember(Name="cancelReason", EmitDefaultValue=false)]
        public string CancelReason { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelTradovateSubscription {\n");
            sb.Append("  TradovateSubscriptionId: ").Append(TradovateSubscriptionId).Append("\n");
            sb.Append("  CancelReason: ").Append(CancelReason).Append("\n");
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
            return this.Equals(obj as CancelTradovateSubscription);
        }

        /// <summary>
        /// Returns true if CancelTradovateSubscription instances are equal
        /// </summary>
        /// <param name="other">Instance of CancelTradovateSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CancelTradovateSubscription other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TradovateSubscriptionId == other.TradovateSubscriptionId ||
                    this.TradovateSubscriptionId != null &&
                    this.TradovateSubscriptionId.Equals(other.TradovateSubscriptionId)
                ) && 
                (
                    this.CancelReason == other.CancelReason ||
                    this.CancelReason != null &&
                    this.CancelReason.Equals(other.CancelReason)
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
                if (this.TradovateSubscriptionId != null)
                    hash = hash * 59 + this.TradovateSubscriptionId.GetHashCode();
                if (this.CancelReason != null)
                    hash = hash * 59 + this.CancelReason.GetHashCode();
                return hash;
            }
        }
    }

}
