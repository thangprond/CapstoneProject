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
    
    public partial class CAT_DIC_SH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAT_DIC_SH()
        {
            this.ITEM_SH = new HashSet<ITEM_SH>();
        }
    
        public int ID { get; set; }
        public string DisplayEntry { get; set; }
        public string AccessEntry { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> DicItemID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_SH> ITEM_SH { get; set; }
    }
}
