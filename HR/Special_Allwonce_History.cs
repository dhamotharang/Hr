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
    
    public partial class Special_Allwonce_History
    {
        public int ID { get; set; }
        public double Year { get; set; }
        public double Month { get; set; }
        public double Percentage { get; set; }
        public double Allowance_amount { get; set; }
        public double pervious_basic { get; set; }
        public double new_basic_sallary { get; set; }
        public int type_allowance { get; set; }
        public int selectedID { get; set; }
        public Nullable<int> Job_level_class_ID { get; set; }
        public Nullable<int> Job_level_grade_ID { get; set; }
        public Nullable<int> job_level_setup_ID { get; set; }
    
        public virtual Job_level_class Job_level_class { get; set; }
        public virtual Job_level_grade Job_level_grade { get; set; }
        public virtual job_level_setup job_level_setup { get; set; }
    }
}
