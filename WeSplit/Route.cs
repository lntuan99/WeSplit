//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeSplit
{
    using System;
    using System.Collections.Generic;
    
    public partial class Route
    {
        public int ID_Journey { get; set; }
        public int Ordinal_Number { get; set; }
        public string Place { get; set; }
        public string Province { get; set; }
        public string Route_Description { get; set; }
        public Nullable<int> Route_Status { get; set; }
    
        public virtual Journey Journey { get; set; }
    }
}
