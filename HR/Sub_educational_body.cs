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
    
    public partial class Sub_educational_body
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sub_educational_body()
        {
            this.Applicant_Qualification_Profile = new HashSet<Applicant_Qualification_Profile>();
            this.Employee_Qualification_Profile = new HashSet<Employee_Qualification_Profile>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Main_Educate_bodyid { get; set; }
        public string Name_of_educational_qualification_IDD { get; set; }
        public Nullable<int> Name_of_educational_qualification_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Applicant_Qualification_Profile> Applicant_Qualification_Profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Qualification_Profile> Employee_Qualification_Profile { get; set; }
        public virtual Main_Educate_body Main_Educate_body { get; set; }
        public virtual Name_of_educational_qualification Name_of_educational_qualification { get; set; }
    }
}
