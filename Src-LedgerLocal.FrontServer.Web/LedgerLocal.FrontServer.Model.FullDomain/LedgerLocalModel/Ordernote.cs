﻿using System;
using System.Collections.Generic;

namespace LedgerLocal.FrontServer.Data.FullDomain
{
    public partial class Ordernote
    {
        public int Ordernoteid { get; set; }
        public int? Orderid { get; set; }
        public int? Ordernotetypeid { get; set; }
        public string Note { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public Order Order { get; set; }
        public Ordernotetype Ordernotetype { get; set; }
    }
}
