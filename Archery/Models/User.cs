using Archery.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Archery.Models
{
    public abstract class User
    {
        public int ID { get; set; }

        [Required(ErrorMessage ="Le Champs {0} est obligatoire.")]
        [Display(Name ="Adresse Email")]
        [StringLength(150, ErrorMessage ="Le champs {0} doit contenir {1} caractères.")]
        [RegularExpression(@"^([a-zA-Z0-9_/-/.]+)@((\[[0-9]{1,3}" + 
                            @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                            @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
                        , ErrorMessage ="Le format n'est pas bon")]
        public string Mail { get; set; }

        [Required]
        [StringLength(150)]
        [DataType(DataType.Password)]
        [RegularExpression(@"(?=^.{8,}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$", ErrorMessage = "{0} est incorrect")]
        public string Password { get; set; }

        [NotMapped]
        [Compare("Password", ErrorMessage ="La Confirmation n'est pas bonne")]
        [Required]
        [DataType(DataType.Password)]
        [StringLength(150)]
        public string ConfirmedPassword { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Prenom")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        
        
        [Required]
        [Column(TypeName ="datetime2")]
        [Age(9,25,ErrorMessage = "Vous devez avoir entre {1} ans")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
    }
}