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
    
    public partial class TB_JOB_SEEKER_SEARCH_CRITERIA_SUBSCRIPTION_NOTIFICATION_HISTORY
    {
        public int ID { get; set; }
        public Nullable<int> JobSeeker_ID { get; set; }
        public Nullable<int> Job_ID { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public Nullable<int> JobSeeker_Subs_ID { get; set; }
    
        public virtual TB_JOB_SEEKER TB_JOB_SEEKER { get; set; }
        public virtual TB_JOB_SEEKER_SEARCH_CRITERIA_SUBSCRIPTION TB_JOB_SEEKER_SEARCH_CRITERIA_SUBSCRIPTION { get; set; }
    }
}
