/*
 * Restler API Explorer
 *
 * Live API Documentation
 *
 * OpenAPI spec version: 1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{ 
    /// <summary>
    /// TradingPairInfo Model
    /// </summary>
    [DataContract]
    public partial class TradingPairInfo : IEquatable<TradingPairInfo>
    { 
        /// <summary>
        /// The type of cryptocoin the end user sends in to the exchange
        /// </summary>
        /// <value>The type of cryptocoin the end user sends in to the exchange</value>
        [Required]
        [DataMember(Name="inputCoinType")]
        public string InputCoinType { get; set; }

        /// <summary>
        /// The type of cryptocoin the exchange will send back to the end user upon receiving an &#39;inputCoinType&#39;
        /// </summary>
        /// <value>The type of cryptocoin the exchange will send back to the end user upon receiving an &#39;inputCoinType&#39;</value>
        [Required]
        [DataMember(Name="outputCoinType")]
        public string OutputCoinType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TradingPairInfo {\n");
            sb.Append("  InputCoinType: ").Append(InputCoinType).Append("\n");
            sb.Append("  OutputCoinType: ").Append(OutputCoinType).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((TradingPairInfo)obj);
        }

        /// <summary>
        /// Returns true if TradingPairInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of TradingPairInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradingPairInfo other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    InputCoinType == other.InputCoinType ||
                    InputCoinType != null &&
                    InputCoinType.Equals(other.InputCoinType)
                ) && 
                (
                    OutputCoinType == other.OutputCoinType ||
                    OutputCoinType != null &&
                    OutputCoinType.Equals(other.OutputCoinType)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (InputCoinType != null)
                    hashCode = hashCode * 59 + InputCoinType.GetHashCode();
                    if (OutputCoinType != null)
                    hashCode = hashCode * 59 + OutputCoinType.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(TradingPairInfo left, TradingPairInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TradingPairInfo left, TradingPairInfo right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}