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
    
    public partial class SP_HOLDING_INFO_SEL_Result
    {
        public string Mark { get; set; }
        public string Imgs { get; set; }
        public int Checked { get; set; }
        public string Readonly { get; set; }
        public int ID { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Shelf { get; set; }
        public string Volume { get; set; }
        public string CallNumber { get; set; }
        public string CopyNumber { get; set; }
        public string RecordNumber { get; set; }
        public Nullable<System.DateTime> ReceiptedDate { get; set; }
        public string Source { get; set; }
        public Nullable<System.DateTime> AcquiredDate { get; set; }
        public Nullable<float> Price { get; set; }
        public string Note { get; set; }
        public bool InUsed { get; set; }
        public int LocationID { get; set; }
        public int LibID { get; set; }
        public Nullable<int> AcquiredSourceID { get; set; }
        public int POID { get; set; }
        public string Currency { get; set; }
    }
}
