﻿using System;
using System.Collections.Generic;

namespace LedgerLocal.FrontServer.Data.FullDomain
{
    public partial class Article
    {
        public Article()
        {
            Articleimagemap = new HashSet<Articleimagemap>();
            Articletagmap = new HashSet<Articletagmap>();
            Comment = new HashSet<Comment>();
        }

        public int Articleid { get; set; }
        public int Cultureid { get; set; }
        public int Userid { get; set; }
        public string Title { get; set; }
        public string Metatitle { get; set; }
        public string Metakeyword { get; set; }
        public string Metadescription { get; set; }
        public string Keywords { get; set; }
        public char Body { get; set; }
        public bool? Ishtml { get; set; }
        public bool Activate { get; set; }
        public DateTime Createdon { get; set; }
        public DateTime Modifiedon { get; set; }
        public string Createdby { get; set; }
        public string Modifiedby { get; set; }
        public char? Imagethumb { get; set; }
        public char? Imagepost { get; set; }

        public Culture Culture { get; set; }
        public User User { get; set; }
        public ICollection<Articleimagemap> Articleimagemap { get; set; }
        public ICollection<Articletagmap> Articletagmap { get; set; }
        public ICollection<Comment> Comment { get; set; }
    }
}
