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
    using System.Collections.Generic;
    
    public partial class CAT_DIC_OAI_SET
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAT_DIC_OAI_SET()
        {
            this.ITEM_OAI_SET = new HashSet<ITEM_OAI_SET>();
        }
    
        public int ID { get; set; }
        public string DisplayEntry { get; set; }
        public string AccessEntry { get; set; }
        public Nullable<int> DicItemID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ITEM_OAI_SET> ITEM_OAI_SET { get; set; }
    }
}
