//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HW_2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menu
    {
        public string MenuNo { get; set; }
        public Nullable<byte> LinkType { get; set; }
        public string LinkName { get; set; }
        public string LinkURL { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<byte> MenuLevel { get; set; }
        public Nullable<System.DateTime> CeateDate { get; set; }
        public string Createuser { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyUser { get; set; }
    }
}
