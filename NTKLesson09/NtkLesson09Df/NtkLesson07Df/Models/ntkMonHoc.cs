//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NtkLesson07Df.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ntkMonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ntkMonHoc()
        {
            this.ntkKetquas = new HashSet<ntkKetqua>();
        }
    
        public string ntkMaMH { get; set; }
        public string ntkTenMH { get; set; }
        public Nullable<decimal> ntkSotiet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ntkKetqua> ntkKetquas { get; set; }
    }
}
