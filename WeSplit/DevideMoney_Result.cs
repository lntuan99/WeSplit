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
    
    public partial class DevideMoney_Result
    {
        public int ID_Member { get; set; }
        public string Member_Name { get; set; }
        public Nullable<decimal> Remain { get; set; }
        public Nullable<decimal> Advance_Money { get; set; }
        public Nullable<int> ID_Lender { get; set; }

        //For Binding
        public string Remain_For_Binding { get; set; }

        public string Advance_Money_Lender { get; set; }
    }
}
