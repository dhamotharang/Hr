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
    
    public partial class skill_eval
    {
        public int id { get; set; }
        public double J_rate { get; set; }
        public double em_rate { get; set; }
        public string GAP { get; set; }
        public int SkillID { get; set; }
        public int EvaluationTransactionID { get; set; }
    
        public virtual EvaluationTransaction EvaluationTransaction { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
