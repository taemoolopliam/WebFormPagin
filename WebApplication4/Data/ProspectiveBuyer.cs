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
    
    public partial class ProspectiveBuyer
    {
        public int ProspectiveBuyerKey { get; set; }
        public string ProspectAlternateKey { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<decimal> YearlyIncome { get; set; }
        public Nullable<byte> TotalChildren { get; set; }
        public Nullable<byte> NumberChildrenAtHome { get; set; }
        public string Education { get; set; }
        public string Occupation { get; set; }
        public string HouseOwnerFlag { get; set; }
        public Nullable<byte> NumberCarsOwned { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvinceCode { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Salutation { get; set; }
        public Nullable<int> Unknown { get; set; }
    }
}
