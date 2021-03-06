﻿using System;
using System.Collections.Generic;

namespace LedgerLocal.FrontServer.Data.FullDomain
{
    public partial class Sourcetype
    {
        public Sourcetype()
        {
            Customexport = new HashSet<Customexport>();
        }

        public int Sourcetypeid { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }

        public ICollection<Customexport> Customexport { get; set; }
    }
}
