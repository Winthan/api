/* 
 * Tradovate API
 *
 * Tradovate API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Tradovate.Services.Model
{
    /// <summary>
    /// ChartSubscriptionResult
    /// </summary>
    [DataContract]
    public partial class ChartSubscriptionResult :  IEquatable<ChartSubscriptionResult>, IValidatableObject
    {
        /// <summary>
        /// NoServicePlan, OperationNotSupported, Success, UnknownReason, UnknownSymbol
        /// </summary>
        /// <value>NoServicePlan, OperationNotSupported, Success, UnknownReason, UnknownSymbol</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ErrorCodeEnum
        {
            
            /// <summary>
            /// Enum OperationNotSupported for "OperationNotSupported"
            /// </summary>
            [EnumMember(Value = "OperationNotSupported")]
            OperationNotSupported,
            
            /// <summary>
            /// Enum UnknownReason for "UnknownReason"
            /// </summary>
            [EnumMember(Value = "UnknownReason")]
            UnknownReason,
            
            /// <summary>
            /// Enum UnknownSymbol for "UnknownSymbol"
            /// </summary>
            [EnumMember(Value = "UnknownSymbol")]
            UnknownSymbol,
            
            /// <summary>
            /// Enum NoServicePlan for "NoServicePlan"
            /// </summary>
            [EnumMember(Value = "NoServicePlan")]
            NoServicePlan,
            
            /// <summary>
            /// Enum Success for "Success"
            /// </summary>
            [EnumMember(Value = "Success")]
            Success
        }

        /// <summary>
        /// Delayed, None, RealTime
        /// </summary>
        /// <value>Delayed, None, RealTime</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            
            /// <summary>
            /// Enum None for "None"
            /// </summary>
            [EnumMember(Value = "None")]
            None,
            
            /// <summary>
            /// Enum Delayed for "Delayed"
            /// </summary>
            [EnumMember(Value = "Delayed")]
            Delayed,
            
            /// <summary>
            /// Enum RealTime for "RealTime"
            /// </summary>
            [EnumMember(Value = "RealTime")]
            RealTime
        }

        /// <summary>
        /// NoServicePlan, OperationNotSupported, Success, UnknownReason, UnknownSymbol
        /// </summary>
        /// <value>NoServicePlan, OperationNotSupported, Success, UnknownReason, UnknownSymbol</value>
        [DataMember(Name="errorCode", EmitDefaultValue=false)]
        public ErrorCodeEnum? ErrorCode { get; set; }
        /// <summary>
        /// Delayed, None, RealTime
        /// </summary>
        /// <value>Delayed, None, RealTime</value>
        [DataMember(Name="mode", EmitDefaultValue=false)]
        public ModeEnum? Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSubscriptionResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChartSubscriptionResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSubscriptionResult" /> class.
        /// </summary>
        /// <param name="ErrorText">Non-empty if the request failed.</param>
        /// <param name="ErrorCode">NoServicePlan, OperationNotSupported, Success, UnknownReason, UnknownSymbol.</param>
        /// <param name="Mode">Delayed, None, RealTime (required).</param>
        /// <param name="HistoricalId">HistoricalId.</param>
        /// <param name="RealtimeId">RealtimeId.</param>
        public ChartSubscriptionResult(string ErrorText = default(string), ErrorCodeEnum? ErrorCode = default(ErrorCodeEnum?), ModeEnum? Mode = default(ModeEnum?), int? HistoricalId = default(int?), int? RealtimeId = default(int?))
        {
            // to ensure "Mode" is required (not null)
            if (Mode == null)
            {
                throw new InvalidDataException("Mode is a required property for ChartSubscriptionResult and cannot be null");
            }
            else
            {
                this.Mode = Mode;
            }
            this.ErrorText = ErrorText;
            this.ErrorCode = ErrorCode;
            this.HistoricalId = HistoricalId;
            this.RealtimeId = RealtimeId;
        }
        
        /// <summary>
        /// Non-empty if the request failed
        /// </summary>
        /// <value>Non-empty if the request failed</value>
        [DataMember(Name="errorText", EmitDefaultValue=false)]
        public string ErrorText { get; set; }
        /// <summary>
        /// Gets or Sets HistoricalId
        /// </summary>
        [DataMember(Name="historicalId", EmitDefaultValue=false)]
        public int? HistoricalId { get; set; }
        /// <summary>
        /// Gets or Sets RealtimeId
        /// </summary>
        [DataMember(Name="realtimeId", EmitDefaultValue=false)]
        public int? RealtimeId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartSubscriptionResult {\n");
            sb.Append("  ErrorText: ").Append(ErrorText).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  HistoricalId: ").Append(HistoricalId).Append("\n");
            sb.Append("  RealtimeId: ").Append(RealtimeId).Append("\n");
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
            return this.Equals(obj as ChartSubscriptionResult);
        }

        /// <summary>
        /// Returns true if ChartSubscriptionResult instances are equal
        /// </summary>
        /// <param name="other">Instance of ChartSubscriptionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChartSubscriptionResult other)
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
                    this.ErrorCode == other.ErrorCode ||
                    this.ErrorCode != null &&
                    this.ErrorCode.Equals(other.ErrorCode)
                ) && 
                (
                    this.Mode == other.Mode ||
                    this.Mode != null &&
                    this.Mode.Equals(other.Mode)
                ) && 
                (
                    this.HistoricalId == other.HistoricalId ||
                    this.HistoricalId != null &&
                    this.HistoricalId.Equals(other.HistoricalId)
                ) && 
                (
                    this.RealtimeId == other.RealtimeId ||
                    this.RealtimeId != null &&
                    this.RealtimeId.Equals(other.RealtimeId)
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
                if (this.ErrorCode != null)
                    hash = hash * 59 + this.ErrorCode.GetHashCode();
                if (this.Mode != null)
                    hash = hash * 59 + this.Mode.GetHashCode();
                if (this.HistoricalId != null)
                    hash = hash * 59 + this.HistoricalId.GetHashCode();
                if (this.RealtimeId != null)
                    hash = hash * 59 + this.RealtimeId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // ErrorText (string) maxLength
            if(this.ErrorText != null && this.ErrorText.Length > 8192)
            {
                yield return new ValidationResult("Invalid value for ErrorText, length must be less than 8192.", new [] { "ErrorText" });
            }

            yield break;
        }
    }

}
