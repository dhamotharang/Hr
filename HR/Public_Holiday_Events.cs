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
    
    public partial class Public_Holiday_Events
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Public_Holiday_Events()
        {
            this.Append_Public_Holidays_Dates = new HashSet<Append_Public_Holidays_Dates>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AlternativeDescription { get; set; }
        public int Type_Holiday { get; set; }
        public int ShiftdaystatussetupId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Append_Public_Holidays_Dates> Append_Public_Holidays_Dates { get; set; }
        public virtual Shift_day_status_setup Shift_day_status_setup { get; set; }
    }
}
