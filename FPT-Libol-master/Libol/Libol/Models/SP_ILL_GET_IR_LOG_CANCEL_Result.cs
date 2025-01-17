//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Libol.Models
{
    using System;
    
    public partial class SP_ILL_GET_IR_LOG_CANCEL_Result
    {
        public int ID { get; set; }
        public int RequesterID { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string Note { get; set; }
        public byte APDUType { get; set; }
        public Nullable<byte> ReasonID { get; set; }
        public Nullable<System.DateTime> ProvidedDate { get; set; }
        public string ResponderSpecReason { get; set; }
        public Nullable<byte> SendShipped { get; set; }
        public Nullable<byte> SendCheckedIn { get; set; }
        public Nullable<byte> SendReceived { get; set; }
        public Nullable<byte> SendReturned { get; set; }
        public Nullable<byte> TRE { get; set; }
        public Nullable<byte> Medium { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public string CurrencyCode1 { get; set; }
        public bool Answer { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public bool Renewable { get; set; }
        public bool Alert { get; set; }
        public int LogID { get; set; }
        public Nullable<byte> ServiceType { get; set; }
        public string Location { get; set; }
        public Nullable<byte> CopyrightCompliance { get; set; }
        public string ReturnedVia { get; set; }
        public Nullable<decimal> InsuredForCost { get; set; }
        public string CurrencyCode2 { get; set; }
        public Nullable<decimal> ReturnInsuranceCost { get; set; }
        public string CurrencyCode3 { get; set; }
    }
}
