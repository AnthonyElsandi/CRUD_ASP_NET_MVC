//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PROJECT_PSD.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public int user_id { get; set; }
        public int medicine_id { get; set; }
        public int quantity { get; set; }
    
        public virtual Medicine Medicine { get; set; }
        public virtual User User { get; set; }
    }
}