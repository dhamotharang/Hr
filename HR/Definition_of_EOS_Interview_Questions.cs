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
    
    public partial class Definition_of_EOS_Interview_Questions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Definition_of_EOS_Interview_Questions()
        {
            this.Answer_EOS = new HashSet<Answer_EOS>();
        }
    
        public int ID { get; set; }
        public string Question_Code { get; set; }
        public string Question_Description { get; set; }
        public string Description { get; set; }
        public string Question_GroupId { get; set; }
        public Nullable<int> EOS_Interview_Questions_Groups_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Answer_EOS> Answer_EOS { get; set; }
        public virtual EOS_Interview_Questions_Groups EOS_Interview_Questions_Groups { get; set; }
    }
}