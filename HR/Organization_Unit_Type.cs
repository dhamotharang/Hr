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
    
    public partial class Organization_Unit_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organization_Unit_Type()
        {
            this.Organization_Chart = new HashSet<Organization_Chart>();
        }
    
        public int ID { get; set; }
        public int Organization_Unit_LevelID { get; set; }
        public int Organization_Unit_SchemaID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> job_level_setup_ID { get; set; }
    
        public virtual job_level_setup job_level_setup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Organization_Chart> Organization_Chart { get; set; }
        public virtual Organization_Unit_Level Organization_Unit_Level { get; set; }
        public virtual Organization_Unit_Schema Organization_Unit_Schema { get; set; }
    }
}
