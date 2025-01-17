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
    
    public partial class SP_EDATA_GET_GENERAL_INFOR_Result
    {
        public string Path { get; set; }
        public int ID { get; set; }
        public int FileSize { get; set; }
        public System.DateTime UploadedDate { get; set; }
        public string UploadedBy { get; set; }
        public string FieldCode { get; set; }
        public Nullable<int> ItemID { get; set; }
        public string URL { get; set; }
        public string PhysicalPath { get; set; }
        public bool Existed { get; set; }
        public string FileLocation { get; set; }
        public int SecretLevel { get; set; }
        public int DownloadTimes { get; set; }
        public int MediaType { get; set; }
        public bool Locked { get; set; }
        public Nullable<System.DateTime> LockedDate { get; set; }
        public string LockedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public int ModifiedTimes { get; set; }
        public int Status { get; set; }
        public string Note { get; set; }
        public Nullable<int> CollectionID { get; set; }
        public bool Free { get; set; }
        public string FileName { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Currency { get; set; }
        public string Pagination { get; set; }
        public string FileFormat { get; set; }
    }
}
