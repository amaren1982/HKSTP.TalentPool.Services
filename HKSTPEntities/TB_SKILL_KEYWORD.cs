//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HKSTPEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_SKILL_KEYWORD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_SKILL_KEYWORD()
        {
            this.TB_JOB_POST_SKILL_KEYWORD = new HashSet<TB_JOB_POST_SKILL_KEYWORD>();
            this.TB_JOB_SEEKER_SKILL_KEYWORD = new HashSet<TB_JOB_SEEKER_SKILL_KEYWORD>();
        }
    
        public int Skill_Keyword_ID { get; set; }
        public string Value { get; set; }
        public Nullable<int> Status { get; set; }
        public string Created_by { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public string Modified_by { get; set; }
        public Nullable<System.DateTime> Modified_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_JOB_POST_SKILL_KEYWORD> TB_JOB_POST_SKILL_KEYWORD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_JOB_SEEKER_SKILL_KEYWORD> TB_JOB_SEEKER_SKILL_KEYWORD { get; set; }
    }
}