//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace database_first_app
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public Nullable<int> training_group_id { get; set; }
    }
}
