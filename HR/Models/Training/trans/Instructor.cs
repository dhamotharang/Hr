//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR.Models.Training.trans
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Instructor")]
    public class Instructor
    {
        public int ID { get; set; }
        [Required(ErrorMessageResourceType = typeof(HR.Resource.Basic), ErrorMessageResourceName = "error_message")]
        [StringLength(50)]
        [Index(IsUnique = true)]
        public string InstructorID { get; set; }
        [Required(ErrorMessageResourceType = typeof(HR.Resource.Basic), ErrorMessageResourceName = "error_message")]
        public string Instructor_FullName { get; set; }
        public string Instructor_ShortName { get; set; }
        public Nullable<short> Gender { get; set; }
        public string CountryCode { get; set; }
        public string Region_Code { get; set; }
        public string State_Governorate_Code { get; set; }
        public string County_Code { get; set; }
        public string City_Code { get; set; }
        public string Zip_Postal_Code { get; set; }
        public string Street_Name { get; set; }
        public Nullable<int> StreetNumber { get; set; }
        public string PO_Box { get; set; }
        public string Company_ID { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
        public int RowIndx { get; set; }
    }
}
