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
    
    public partial class SP_SER_GET_RECEIVE_ISSUES_Result
    {
        public string Note { get; set; }
        public bool SpecialIssue { get; set; }
        public string SpecialTitle { get; set; }
        public int ID { get; set; }
        public string VolumeByPublisher { get; set; }
        public string VolumeByLibrary { get; set; }
        public string IssueNo { get; set; }
        public string Series { get; set; }
        public string OvIssueNo { get; set; }
        public string PhysDetail { get; set; }
        public Nullable<int> ReceivedCopies { get; set; }
        public decimal Price { get; set; }
        public System.DateTime IssuedDate { get; set; }
    }
}
