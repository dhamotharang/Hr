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
    
    public partial class man_power
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public man_power()
        {
            this.items_man_power = new HashSet<items_man_power>();
        }
    
        public int ID { get; set; }
        public int from_year { get; set; }
        public int to_year { get; set; }
        public int Organization_ChartID { get; set; }
        public Nullable<int> status_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<items_man_power> items_man_power { get; set; }
        public virtual Organization_Chart Organization_Chart { get; set; }
        public virtual status status { get; set; }
    }
}