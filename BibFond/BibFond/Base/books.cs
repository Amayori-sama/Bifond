//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BibFond.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class books
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public books()
        {
            this.myBooklist = new HashSet<myBooklist>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string genres { get; set; }
        public Nullable<int> authorId { get; set; }
        public Nullable<int> publishhouseId { get; set; }
        public byte[] image { get; set; }
    
        public virtual author author { get; set; }
        public virtual publishhouse publishhouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<myBooklist> myBooklist { get; set; }
    }
}