//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication4.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class FactSurveyResponse
    {
        public int SurveyResponseKey { get; set; }
        public int DateKey { get; set; }
        public int CustomerKey { get; set; }
        public int ProductCategoryKey { get; set; }
        public string EnglishProductCategoryName { get; set; }
        public int ProductSubcategoryKey { get; set; }
        public string EnglishProductSubcategoryName { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual DimCustomer DimCustomer { get; set; }
        public virtual DimDate DimDate { get; set; }
    }
}