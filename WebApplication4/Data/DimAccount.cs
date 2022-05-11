//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DimAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DimAccount()
        {
            this.DimAccount1 = new HashSet<DimAccount>();
            this.FactFinances = new HashSet<FactFinance>();
        }
    
        public int AccountKey { get; set; }
        public Nullable<int> ParentAccountKey { get; set; }
        public Nullable<int> AccountCodeAlternateKey { get; set; }
        public Nullable<int> ParentAccountCodeAlternateKey { get; set; }
        public string AccountDescription { get; set; }
        public string AccountType { get; set; }
        public string Operator { get; set; }
        public string CustomMembers { get; set; }
        public string ValueType { get; set; }
        public string CustomMemberOptions { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DimAccount> DimAccount1 { get; set; }
        public virtual DimAccount DimAccount2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FactFinance> FactFinances { get; set; }
    }
}
