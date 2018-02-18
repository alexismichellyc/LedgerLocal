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
    public partial class WorkflowExecutionDescription :  IEquatable<WorkflowExecutionDescription>
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowExecutionDescription" /> class.
        /// </summary>
        /// <param name="workflowId">WorkflowId.</param>
        /// <param name="name">workflow name. (required).</param>
        /// <param name="isSuccess">Points Per Purchase Volume.</param>
        /// <param name="HasExpirationAfterCustomerUnactivity">Check.</param>
        /// <param name="CustomerUnactivityThreshold">Description CustomerUnactivityThreshold.</param>
        public WorkflowExecutionDescription(string workflowId = default(string), string name = default(string), bool isSuccess = false)
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for WorkflowDescription and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            this.WorkflowId = WorkflowId;
            this.IsSuccess = isSuccess;
            
        }

        /// <summary>
        /// Gets or Sets WorkflowId
        /// </summary>
        [DataMember(Name="workflowId")]
        public string WorkflowId { get; set; }
        /// <summary>
        /// workflow name.
        /// </summary>
        /// <value>workflow name.</value>
        [DataMember(Name="name")]
        public string Name { get; set; }
        /// <summary>
        /// Is Workflow Success
        /// </summary>
        /// <value>Workflow Success</value>
        [DataMember(Name= "isSuccess")]
        public bool IsSuccess { get; set; }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkflowExecutionDescription {\n");
            sb.Append("  WorkflowId: ").Append(WorkflowId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PointsPerPurchaseVolume: ").Append(IsSuccess).Append("\n");
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
            return Equals((WorkflowExecutionDescription)obj);
        }

        /// <summary>
        /// Returns true if WorkflowDescription instances are equal
        /// </summary>
        /// <param name="other">Instance of WorkflowDescription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkflowExecutionDescription other)
        {

            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    this.WorkflowId == other.WorkflowId ||
                    this.WorkflowId != null &&
                    this.WorkflowId.Equals(other.WorkflowId)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.IsSuccess == other.IsSuccess ||
                    this.IsSuccess.Equals(other.IsSuccess)
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
                    if (this.WorkflowId != null)
                    hash = hash * 59 + this.WorkflowId.GetHashCode();
                    if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                    hash = hash * 59 + this.IsSuccess.GetHashCode();
                return hash;
            }
        }

        #region Operators

        public static bool operator ==(WorkflowExecutionDescription left, WorkflowExecutionDescription right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(WorkflowExecutionDescription left, WorkflowExecutionDescription right)
        {
            return !Equals(left, right);
        }

        #endregion Operators

    }
}
