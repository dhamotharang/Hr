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
    
    public partial class Basic_Salary_Calculation_Result
    {
        public int ID { get; set; }
        public int Start_Basic_Salary { get; set; }
        public int Other_Allowance { get; set; }
        public int Basic_Salary_A { get; set; }
        public int Total_Included_Allowances { get; set; }
        public int Total_Execluded_Allowances { get; set; }
        public int Total_Basic_Salary { get; set; }
        public int Total_Remuneration { get; set; }
        public int Insurance_Basic_Salary { get; set; }
        public int Insurance_Variable_Salary { get; set; }
        public int ApplicantId { get; set; }
        public Nullable<int> Application_ID { get; set; }
    
        public virtual Application Application { get; set; }
    }
}
