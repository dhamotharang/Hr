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
    
    public partial class Employee_experience_profile
    {
        public int ID { get; set; }
        public string Employee_ProfileId { get; set; }
        public string Code { get; set; }
        public string External_compainesId { get; set; }
        public string Rejection_ReasonsId { get; set; }
        public string Company_type { get; set; }
        public string Job_title { get; set; }
        public System.DateTime Start_date { get; set; }
        public System.DateTime End_date { get; set; }
        public int Years { get; set; }
        public int Days { get; set; }
        public int Months { get; set; }
        public double Total_salary { get; set; }
        public int Added_months { get; set; }
        public int Added_years { get; set; }
        public int Added_days { get; set; }
        public int Considered_period { get; set; }
        public System.DateTime Approval_date { get; set; }
        public Nullable<int> Employee_Profile_ID { get; set; }
        public Nullable<int> External_compaines_ID { get; set; }
        public Nullable<int> Rejection_Reasons_ID { get; set; }
    
        public virtual Employee_Profile Employee_Profile { get; set; }
        public virtual External_compaines External_compaines { get; set; }
        public virtual Rejection_Reasons Rejection_Reasons { get; set; }
    }
}
