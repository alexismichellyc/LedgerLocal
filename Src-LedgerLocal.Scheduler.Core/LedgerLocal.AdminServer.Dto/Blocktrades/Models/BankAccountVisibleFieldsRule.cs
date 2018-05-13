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
    /// BankAccountVisibleFieldsRule Model
    /// </summary>
    [DataContract]
    public partial class BankAccountVisibleFieldsRule : IEquatable<BankAccountVisibleFieldsRule>
    { 
        /// <summary>
        /// array of receiving countries
        /// </summary>
        /// <value>array of receiving countries</value>
        [Required]
        [DataMember(Name="countries")]
        public List<string> Countries { get; set; }

        /// <summary>
        /// array of currencies
        /// </summary>
        /// <value>array of currencies</value>
        [Required]
        [DataMember(Name="currencies")]
        public List<string> Currencies { get; set; }

        /// <summary>
        /// array of field names
        /// </summary>
        /// <value>array of field names</value>
        [Required]
        [DataMember(Name="requiredFields")]
        public List<string> RequiredFields { get; set; }

        /// <summary>
        /// array of field names
        /// </summary>
        /// <value>array of field names</value>
        [Required]
        [DataMember(Name="optionalFields")]
        public List<string> OptionalFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankAccountVisibleFieldsRule {\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
            sb.Append("  RequiredFields: ").Append(RequiredFields).Append("\n");
            sb.Append("  OptionalFields: ").Append(OptionalFields).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BankAccountVisibleFieldsRule)obj);
        }

        /// <summary>
        /// Returns true if BankAccountVisibleFieldsRule instances are equal
        /// </summary>
        /// <param name="other">Instance of BankAccountVisibleFieldsRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankAccountVisibleFieldsRule other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Countries == other.Countries ||
                    Countries != null &&
                    Countries.SequenceEqual(other.Countries)
                ) && 
                (
                    Currencies == other.Currencies ||
                    Currencies != null &&
                    Currencies.SequenceEqual(other.Currencies)
                ) && 
                (
                    RequiredFields == other.RequiredFields ||
                    RequiredFields != null &&
                    RequiredFields.SequenceEqual(other.RequiredFields)
                ) && 
                (
                    OptionalFields == other.OptionalFields ||
                    OptionalFields != null &&
                    OptionalFields.SequenceEqual(other.OptionalFields)
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
                    if (Countries != null)
                    hashCode = hashCode * 59 + Countries.GetHashCode();
                    if (Currencies != null)
                    hashCode = hashCode * 59 + Currencies.GetHashCode();
                    if (RequiredFields != null)
                    hashCode = hashCode * 59 + RequiredFields.GetHashCode();
                    if (OptionalFields != null)
                    hashCode = hashCode * 59 + OptionalFields.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BankAccountVisibleFieldsRule left, BankAccountVisibleFieldsRule right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BankAccountVisibleFieldsRule left, BankAccountVisibleFieldsRule right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}