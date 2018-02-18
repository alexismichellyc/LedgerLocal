/*
 * LedgerLocal Server API
 *
 * LedgerLocal Server API swagger-2.0 specification
 *
 * OpenAPI spec version: 1.0.0.0
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
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace LedgerLocal.FrontServer.Api.Web.Models
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class SuccessModel :  IEquatable<SuccessModel>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SuccessModel" /> class.
        /// </summary>
        /// <param name="Code">Code (required).</param>
        /// <param name="Message">Message (required).</param>
        public SuccessModel(int? Code = default(int?), string Message = default(string))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for SuccessModel and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for SuccessModel and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code")]
        public int? Code { get; set; }
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message")]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuccessModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            if (obj.GetType() != GetType()) return false;
            return Equals((SuccessModel)obj);
        }

        /// <summary>
        /// Returns true if SuccessModel instances are equal
        /// </summary>
        /// <param name="other">Instance of SuccessModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuccessModel other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                    if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                    if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(SuccessModel left, SuccessModel right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SuccessModel left, SuccessModel right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
