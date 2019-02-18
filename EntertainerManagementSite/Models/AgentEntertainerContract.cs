//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntertainerManagementSite.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AgentEntertainerContract
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AgentEntertainerContract()
        {
            this.EntertainerGroups = new HashSet<EntertainerGroup>();
        }
    
        public int Contract_ID { get; set; }
        public int FK_agentID { get; set; }
        public decimal Contract_agentFee { get; set; }
        public string Contract_detail { get; set; }
        public System.DateTime Contract_date { get; set; }
        public System.DateTime Contract_expDate { get; set; }
    
        public virtual Agent Agent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntertainerGroup> EntertainerGroups { get; set; }
    }
}
