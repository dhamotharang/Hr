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
    
    public partial class the_states
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public the_states()
        {
            this.Air_ports = new HashSet<Air_ports>();
            this.Applicant_Address_Profile = new HashSet<Applicant_Address_Profile>();
            this.Applicant_Profile = new HashSet<Applicant_Profile>();
            this.Employee_Address_Profile = new HashSet<Employee_Address_Profile>();
            this.Employee_Profile = new HashSet<Employee_Profile>();
            this.Territories = new HashSet<Territory>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Areaid { get; set; }
        public string CountryID { get; set; }
        public Nullable<int> Area_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Air_ports> Air_ports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Applicant_Address_Profile> Applicant_Address_Profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Applicant_Profile> Applicant_Profile { get; set; }
        public virtual Area Area { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Address_Profile> Employee_Address_Profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Profile> Employee_Profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Territory> Territories { get; set; }
    }
}
