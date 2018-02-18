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

    [DataContract]
    public partial class VoucherCalculated
    {

        [DataMember(Name = "customerId")]
        public string CustomerId { get; set; }

        [DataMember(Name="timestamp")]
        public DateTime? Timestamp { get; set; }

        [DataMember(Name="success")]
        public bool? Success { get; set; }

        [DataMember(Name = "reason")]
        public string Reason { get; set; }

    }
}
