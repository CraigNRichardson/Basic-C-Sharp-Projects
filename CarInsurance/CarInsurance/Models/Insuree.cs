//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarInsurance.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Insuree
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public int CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public bool DUI { get; set; }
        public int SpeedingTickets { get; set; }
        public bool CoverageType { get; set; }
        public decimal Quote { get; set; }
    }

    [MetadataType(typeof(InsureeMetaData))]
    public partial class Insuree
    {
    }

    public class InsureeMetaData
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Date of Birth")]
        public string DateOfBirth { get; set; }

        [Display(Name = "Car Year")]
        public string CarYear { get; set; }

        [Display(Name = "Car Make")]
        public string CarMake { get; set; }

        [Display(Name = "Car Model")]
        public string CarModel { get; set; }

        [Display(Name = "Speeding Tickets")]
        public string SpeedingTickets { get; set; }

        [Display(Name = "DUI")]
        public string DUI { get; set; }

        [Display(Name = "Full Coverage")]
        public string CoverageType { get; set; }

        [Display(Name = "Insurance Premium")]
        public string Quote { get; set; }
    }
}
