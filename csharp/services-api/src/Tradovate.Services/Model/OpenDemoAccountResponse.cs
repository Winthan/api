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
    /// OpenDemoAccountResponse
    /// </summary>
    [DataContract]
    public partial class OpenDemoAccountResponse :  IEquatable<OpenDemoAccountResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenDemoAccountResponse" /> class.
        /// </summary>
        /// <param name="ErrorText">Non-empty if the request failed.</param>
        /// <param name="AccountId">id of Account.</param>
        public OpenDemoAccountResponse(string ErrorText = null, int? AccountId = null)
        {
            this.ErrorText = ErrorText;
            this.AccountId = AccountId;
        }
        
        /// <summary>
        /// Non-empty if the request failed
        /// </summary>
        /// <value>Non-empty if the request failed</value>
        [DataMember(Name="errorText", EmitDefaultValue=false)]
        public string ErrorText { get; set; }
        /// <summary>
        /// id of Account
        /// </summary>
        /// <value>id of Account</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public int? AccountId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenDemoAccountResponse {\n");
            sb.Append("  ErrorText: ").Append(ErrorText).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
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
            return this.Equals(obj as OpenDemoAccountResponse);
        }

        /// <summary>
        /// Returns true if OpenDemoAccountResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OpenDemoAccountResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenDemoAccountResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ErrorText == other.ErrorText ||
                    this.ErrorText != null &&
                    this.ErrorText.Equals(other.ErrorText)
                ) && 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
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
                if (this.ErrorText != null)
                    hash = hash * 59 + this.ErrorText.GetHashCode();
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                return hash;
            }
        }
    }

}
