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
    
    public partial class SP_GETLOANTYPES_Result
    {
        public int ID { get; set; }
        public decimal Fee { get; set; }
        public bool FixedFee { get; set; }
        public int LoanPeriod { get; set; }
        public string LoanType { get; set; }
        public decimal OverdueFine { get; set; }
        public int RenewalPeriod { get; set; }
        public Nullable<int> Renewals { get; set; }
        public int TimeUnit { get; set; }
        public string Mark { get; set; }
        public string strTimeUnit { get; set; }
        public string strFixedFee { get; set; }
        public string strLoanTypeView { get; set; }
    }
}
