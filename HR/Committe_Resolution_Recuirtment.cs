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
    
    public partial class Committe_Resolution_Recuirtment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Committe_Resolution_Recuirtment()
        {
            this.Append_Committe_Member = new HashSet<Append_Committe_Member>();
            this.Commitee_Agenda = new HashSet<Commitee_Agenda>();
            this.Committe_Activities = new HashSet<Committe_Activities>();
            this.In_Organization = new HashSet<In_Organization>();
            this.Linked_to_Testing = new HashSet<Linked_to_Testing>();
            this.Out_Organization = new HashSet<Out_Organization>();
            this.Personnel_Committee_Profile = new HashSet<Personnel_Committee_Profile>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public int Committe_Usage { get; set; }
        public string Committe_Location { get; set; }
        public string Description_Alternative { get; set; }
        public System.DateTime Committe_Resolution_Date { get; set; }
        public int Committe_Year { get; set; }
        public int Committe_Resolution_Status { get; set; }
        public int Committe_Type { get; set; }
        public string Committe_Conclusion { get; set; }
        public int check_status { get; set; }
        public int statID { get; set; }
        public string name_state { get; set; }
        public Nullable<int> status_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Append_Committe_Member> Append_Committe_Member { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commitee_Agenda> Commitee_Agenda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Committe_Activities> Committe_Activities { get; set; }
        public virtual status status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<In_Organization> In_Organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Linked_to_Testing> Linked_to_Testing { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Out_Organization> Out_Organization { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personnel_Committee_Profile> Personnel_Committee_Profile { get; set; }
    }
}
