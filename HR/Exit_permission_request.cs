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
    
    public partial class Exit_permission_request
    {
        public int ID { get; set; }
        public string Request_Number { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> Employee_ProfileID { get; set; }
        public Nullable<int> Exit_permission_typeID { get; set; }
        public Nullable<int> Exit_Permission_ReasonID { get; set; }
        public string Notes { get; set; }
        public System.TimeSpan From { get; set; }
        public System.TimeSpan To { get; set; }
        public int statusID { get; set; }
        public int check_status { get; set; }
    
        public virtual Employee_Profile Employee_Profile { get; set; }
        public virtual Exit_Permission_Reason Exit_Permission_Reason { get; set; }
        public virtual Exit_permission_type Exit_permission_type { get; set; }
        public virtual status status { get; set; }
    }
}
