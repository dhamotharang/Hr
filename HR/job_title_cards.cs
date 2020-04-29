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
    
    public partial class job_title_cards
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public job_title_cards()
        {
            this.Applicant_Profile = new HashSet<Applicant_Profile>();
            this.items_man_power = new HashSet<items_man_power>();
            this.Job_title_sub_class = new HashSet<Job_title_sub_class>();
            this.personnel_transaction = new HashSet<personnel_transaction>();
            this.Position_Information = new HashSet<Position_Information>();
            this.Position_Information_Rec = new HashSet<Position_Information_Rec>();
            this.Slots = new HashSet<Slot>();
            this.Tests = new HashSet<Test>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
        public string job_Summery { get; set; }
        public string Job_alt_summery { get; set; }
        public int from_age { get; set; }
        public int to_age { get; set; }
        public int num_slots { get; set; }
        public string parent_job { get; set; }
        public string joblevelsetupID { get; set; }
        public string Default_job_title_sub_classID { get; set; }
        public string nationalityID { get; set; }
        public int gender { get; set; }
        public int working_system { get; set; }
        public int check_status { get; set; }
        public int validity { get; set; }
        public int parment { get; set; }
        public string Job_DetailsID { get; set; }
        public int number_hired { get; set; }
        public int number_vacant { get; set; }
        public string Organization_unit_codeID { get; set; }
        public int statuss { get; set; }
        public Nullable<int> Job_Details_ID { get; set; }
        public Nullable<int> job_level_setup_ID { get; set; }
        public Nullable<int> Nationality_ID { get; set; }
        public Nullable<int> Organization_Chart_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Applicant_Profile> Applicant_Profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<items_man_power> items_man_power { get; set; }
        public virtual Job_Details Job_Details { get; set; }
        public virtual job_level_setup job_level_setup { get; set; }
        public virtual Nationality Nationality { get; set; }
        public virtual Organization_Chart Organization_Chart { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job_title_sub_class> Job_title_sub_class { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<personnel_transaction> personnel_transaction { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Position_Information> Position_Information { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Position_Information_Rec> Position_Information_Rec { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slot> Slots { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Test> Tests { get; set; }
    }
}
