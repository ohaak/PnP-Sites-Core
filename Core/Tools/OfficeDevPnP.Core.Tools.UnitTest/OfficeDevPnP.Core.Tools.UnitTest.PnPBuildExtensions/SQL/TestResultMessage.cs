//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OfficeDevPnP.Core.Tools.UnitTest.PnPBuildExtensions.SQL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestResultMessage
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Text { get; set; }
        public int TestResultId { get; set; }
    
        public virtual TestResult TestResult { get; set; }
    }
}