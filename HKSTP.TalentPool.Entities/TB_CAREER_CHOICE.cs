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
    
    public partial class TB_CAREER_CHOICE
    {
        public int Career_Choice_ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string URL_Link { get; set; }
        public Nullable<int> Status { get; set; }
        public string Created_by { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public string Modified_by { get; set; }
        public Nullable<System.DateTime> Modified_date { get; set; }
        public string Tooltip { get; set; }
        public Nullable<int> seq { get; set; }
        public byte[] Full_Size_Image { get; set; }
    }
}
