//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OPAC.Models
{
    using System;
    
    public partial class SP_GET_HOLDING_HOL_INFOR1_Result
    {
        public bool Acquired { get; set; }
        public int ID { get; set; }
        public string Content { get; set; }
        public int Volume { get; set; }
        public Nullable<System.DateTime> AcquiredDate { get; set; }
        public string CopyNumber { get; set; }
        public string CallNumber { get; set; }
        public string Shelf { get; set; }
        public bool InUsed { get; set; }
        public Nullable<bool> InCirculation { get; set; }
        public string Note { get; set; }
        public Nullable<System.DateTime> DateLastUsed { get; set; }
        public Nullable<float> Price { get; set; }
        public int UseCount { get; set; }
    }
}
