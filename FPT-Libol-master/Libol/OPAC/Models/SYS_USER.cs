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
    using System.Collections.Generic;
    
    public partial class SYS_USER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYS_USER()
        {
            this.SYS_USER_RIGHT_DETAIL = new HashSet<SYS_USER_RIGHT_DETAIL>();
            this.HOLDING_LOCATION = new HashSet<HOLDING_LOCATION>();
            this.HOLDING_LOCATION1 = new HashSet<HOLDING_LOCATION>();
            this.SYS_REFERENCE = new HashSet<SYS_REFERENCE>();
            this.HOLDING_LOCATION2 = new HashSet<HOLDING_LOCATION>();
        }
    
        public int ID { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<byte> Priority { get; set; }
        public bool AcqModule { get; set; }
        public bool SerModule { get; set; }
        public bool CirModule { get; set; }
        public bool PatModule { get; set; }
        public bool CatModule { get; set; }
        public bool AdmModule { get; set; }
        public bool ILLModule { get; set; }
        public bool DelModule { get; set; }
        public string Unit { get; set; }
        public string LocModule { get; set; }
        public string LDAPAdsPath { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_USER_RIGHT_DETAIL> SYS_USER_RIGHT_DETAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOLDING_LOCATION> HOLDING_LOCATION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOLDING_LOCATION> HOLDING_LOCATION1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYS_REFERENCE> SYS_REFERENCE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOLDING_LOCATION> HOLDING_LOCATION2 { get; set; }
    }
}
