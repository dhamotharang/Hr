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
    
    public partial class qulification_job
    {
        public int ID { get; set; }
        public string Name_of_educational_qualificationID { get; set; }
        public string GradeEducateID { get; set; }
        public string Qualification_MajorID { get; set; }
        public bool required { get; set; }
        public Nullable<int> GradeEducate_ID { get; set; }
        public Nullable<int> Name_of_educational_qualification_ID { get; set; }
        public Nullable<int> Qualification_Major_ID { get; set; }
        public Nullable<int> Job_Details_ID { get; set; }
    
        public virtual GradeEducate GradeEducate { get; set; }
        public virtual Job_Details Job_Details { get; set; }
        public virtual Name_of_educational_qualification Name_of_educational_qualification { get; set; }
        public virtual Qualification_Major Qualification_Major { get; set; }
    }
}
