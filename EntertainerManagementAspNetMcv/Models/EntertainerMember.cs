//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntertainerManagementAspNetMcv.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EntertainerMember
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EntertainerMember()
        {
            this.EntertainerGroups = new HashSet<EntertainerGroup>();
        }
    
        public int eMember_ID { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntertainerGroup> EntertainerGroups { get; set; }
    }
}
