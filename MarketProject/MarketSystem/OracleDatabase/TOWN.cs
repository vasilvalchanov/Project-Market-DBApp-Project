//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketSystem.OracleDatabase
{
    using System;
    using System.Collections.Generic;
    
    public partial class TOWN
    {
        public TOWN()
        {
            this.SUPERMARKETS = new HashSet<SUPERMARKET>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
    
        public virtual ICollection<SUPERMARKET> SUPERMARKETS { get; set; }
    }
}
