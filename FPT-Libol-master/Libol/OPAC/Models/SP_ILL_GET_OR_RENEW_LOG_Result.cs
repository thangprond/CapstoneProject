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
    
    public partial class SP_ILL_GET_OR_RENEW_LOG_Result
    {
        public bool Renewable { get; set; }
        public Nullable<System.DateTime> DueDate { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public int ResponderID { get; set; }
        public int LogID { get; set; }
    }
}
