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
    
    public partial class TB_JOB_SEEKER_CERTIFICATE
    {
        public int ID { get; set; }
        public Nullable<int> JobSeeker_CV_ID { get; set; }
        public string Name_of_Certificate { get; set; }
        public Nullable<int> Issue_date { get; set; }
        public string Issued_by { get; set; }
        public Nullable<bool> Expired { get; set; }
    
        public virtual TB_JOB_SEEKER_CV TB_JOB_SEEKER_CV { get; set; }
    }
}
