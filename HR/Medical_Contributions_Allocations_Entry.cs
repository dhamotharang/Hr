//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR
{
    using System;
    using System.Collections.Generic;
    
    public partial class Medical_Contributions_Allocations_Entry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medical_Contributions_Allocations_Entry()
        {
            this.Medical_Contributions_Allocations_Services = new HashSet<Medical_Contributions_Allocations_Services>();
        }
    
        public int ID { get; set; }
        public double Code { get; set; }
        public string Name { get; set; }
        public string TName { get; set; }
        public bool Is_Contribution { get; set; }
        public int Allowed_To { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Medical_Contributions_Allocations_Services> Medical_Contributions_Allocations_Services { get; set; }
    }
}