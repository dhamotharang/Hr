//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR.Models.Training.setup
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Course_SubGroups")]
    public class Course_SubGroups
    {
        public int ID { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resource.Basic), ErrorMessageResourceName = "error_message")]
        [StringLength(50)]
        [Index(IsUnique = true)]
        public string SubGroup_Code { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resource.Basic), ErrorMessageResourceName = "error_message")]
        public string SubGroup_Desc { get; set; }
        public string SubGroup_AltDesc { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resource.Basic), ErrorMessageResourceName = "error_message")]
        public string Group_Code { get; set; }
        public string Company_ID { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_Date { get; set; }
        public int RowIndx { get; set; }
    }
}
