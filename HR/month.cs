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
    
    public partial class month
    {
        public int id { get; set; }
        public string Name { get; set; }
        public float value { get; set; }
        public Nullable<int> Exchange_Rate_ID { get; set; }
    
        public virtual Exchange_Rate Exchange_Rate { get; set; }
    }
}
