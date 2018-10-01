using Archery.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Archery.Models
{
    public class Archer : User
    {
        [Display(Name="Numéro de licence")]
        [Required]
        [Index(IsUnique = true)]
        [LicenseNumber(ErrorMessage = "Cette licence c'est déja inscrite")]
        [StringLength(15)]
        public string LicenseNumber { get; set; }
    }
}