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
    
    public partial class Employee_Shift_schedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee_Shift_schedule()
        {
            this.Schedule_Details = new HashSet<Schedule_Details>();
        }
    
        public int ID { get; set; }
        public System.DateTime From_date { get; set; }
        public System.DateTime To_date { get; set; }
        public bool Use_As_Default { get; set; }
        public Nullable<int> Employee_ProfileID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        public virtual Employee_Profile Employee_Profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule_Details> Schedule_Details { get; set; }
    }
}
