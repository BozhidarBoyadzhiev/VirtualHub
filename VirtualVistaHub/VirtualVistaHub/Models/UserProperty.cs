//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualVistaHub.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserProperty
    {
        public int UserIdOfSeller { get; set; }
        public int UserIdOfBuyer { get; set; }
        public int PropertyId { get; set; }
        public string TypeOfRequest { get; set; }
    
        public virtual Property Property { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
