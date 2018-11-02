//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIPSorcery.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class SimpleWizardRule
    {
        public string ID { get; set; }
        public string Owner { get; set; }
        public string DialPlanID { get; set; }
        public string Direction { get; set; }
        public decimal Priority { get; set; }
        public string Description { get; set; }
        public string ToMatchType { get; set; }
        public string ToMatchParameter { get; set; }
        public string ToSIPAccount { get; set; }
        public string ToProvider { get; set; }
        public string PatternType { get; set; }
        public string Pattern { get; set; }
        public string Command { get; set; }
        public string CommandParameter1 { get; set; }
        public string CommandParameter2 { get; set; }
        public string CommandParameter3 { get; set; }
        public string CommandParameter4 { get; set; }
        public string TimePattern { get; set; }
        public bool IsDisabled { get; set; }
    
        public virtual SIPDialPlan SIPDialPlan { get; set; }
    }
}