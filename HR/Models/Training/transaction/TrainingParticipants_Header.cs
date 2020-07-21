//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR.Models.Training.transaction
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("TrainingParticipants_Header")]
    public  class TrainingParticipants_Header
    {
        public int ID { get; set; }
        [Required(ErrorMessageResourceType = typeof(HR.Resource.Basic), ErrorMessageResourceName = "error_message")]
        public int Year { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessageResourceType = typeof(HR.Resource.Basic), ErrorMessageResourceName = "error_message")]
        public string TrainingType_Code { get; set; }
        public string CourseClassification_Code { get; set; }
        public string Course_Code { get; set; }
        public string TrainingCenters_Code { get; set; }
        public string Branch_Code { get; set; }
        public Nullable<short> Number_Of_Days { get; set; }
        public Nullable<double> Cost_Per_Person { get; set; }
        public string Company_ID { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
        public int RowIndx { get; set; }


        public int TrainingPlan_HeaderID { get; set; }
        public int details_id { get; set; }
    }
}
