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
    
    public partial class EvaluationTransaction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EvaluationTransaction()
        {
            this.A_Q = new HashSet<A_Q>();
            this.Evalu_Element_Tran = new HashSet<Evalu_Element_Tran>();
            this.obje_eval_tran = new HashSet<obje_eval_tran>();
            this.skill_eval = new HashSet<skill_eval>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public System.DateTime AppraisalDate { get; set; }
        public string planLine { get; set; }
        public System.DateTime FromeDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public int Employee_ProfileID { get; set; }
        public int EvaluationPlanID { get; set; }
        public int statusID { get; set; }
        public int check_status { get; set; }
        public double H_degree { get; set; }
        public double M_degree { get; set; }
        public double average { get; set; }
        public double final { get; set; }
        public int num { get; set; }
        public double def { get; set; }
        public string Desc_grade { get; set; }
        public string total { get; set; }
        public int PerformanceEvaluationGroupID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<A_Q> A_Q { get; set; }
        public virtual Employee_Profile Employee_Profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Evalu_Element_Tran> Evalu_Element_Tran { get; set; }
        public virtual EvaluationPlan EvaluationPlan { get; set; }
        public virtual PerformanceEvaluationGroup PerformanceEvaluationGroup { get; set; }
        public virtual status status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<obje_eval_tran> obje_eval_tran { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<skill_eval> skill_eval { get; set; }
    }
}
