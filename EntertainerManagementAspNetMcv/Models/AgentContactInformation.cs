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
    
    public partial class AgentContactInformation
    {
        public int FK_AgentID { get; set; }
        public string ContactInfo_phoneNo { get; set; }
        public string ContactInfo_phoneNoExt { get; set; }
        public string ContactInfo_email { get; set; }
        public string ContactInfo_type { get; set; }
    
        public virtual Agent Agent { get; set; }
    }
}
