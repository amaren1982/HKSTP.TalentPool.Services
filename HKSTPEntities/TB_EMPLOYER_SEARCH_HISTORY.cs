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
    
    public partial class TB_EMPLOYER_SEARCH_HISTORY
    {
        public int ID { get; set; }
        public Nullable<int> Employer_ID { get; set; }
        public Nullable<int> Job_Function { get; set; }
        public string Search_Keyword { get; set; }
        public Nullable<int> Salary_From { get; set; }
        public Nullable<int> Salary_To { get; set; }
        public Nullable<int> Education_Level { get; set; }
        public Nullable<System.DateTime> Created_date { get; set; }
        public string Employer_Account { get; set; }
        public Nullable<int> Job_ID { get; set; }
    }
}