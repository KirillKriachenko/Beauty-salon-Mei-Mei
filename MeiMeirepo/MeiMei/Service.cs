//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeiMei
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        public int Id { get; set; }
        public string ServiceName { get; set; }
        public string ServiceCost { get; set; }
        public int TypeOfServiceId { get; set; }
    
        public virtual TypeOfService TypeOfService { get; set; }
    }
}