//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HKSTP.TalentPool.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_COMPANY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_COMPANY()
        {
            this.TB_JOB_POST = new HashSet<TB_JOB_POST>();
        }
    
        public int Company_ID { get; set; }
        public Nullable<System.Guid> Company_GUID { get; set; }
        public string Company_Name { get; set; }
        public byte[] Company_Logo { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> Move_in_date { get; set; }
        public Nullable<System.DateTime> Move_out_date { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public Nullable<System.DateTime> Modified_date { get; set; }
        public string Company_Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_JOB_POST> TB_JOB_POST { get; set; }
    }
}
