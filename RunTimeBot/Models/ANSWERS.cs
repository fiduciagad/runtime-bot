//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RunTimeBot.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ANSWERS
    {
        public int Id { get; set; }
        public int intent_type_id { get; set; }
        public int answer_type_id { get; set; }
        public string text { get; set; }
    
        public virtual ANSWERS_TYPE ANSWERS_TYPE { get; set; }
        public virtual INTENT_TYPE INTENT_TYPE { get; set; }
    }
}
