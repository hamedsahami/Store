//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public string FoamType { get; set; }
        public string WoodType { get; set; }
        public Nullable<int> FoamCost { get; set; }
        public Nullable<int> WoodCost { get; set; }
        public Nullable<int> OriginalCost { get; set; }
        public Nullable<int> PrimaryPrice { get; set; }
        public Nullable<int> CorporatePrice { get; set; }
    }
}
