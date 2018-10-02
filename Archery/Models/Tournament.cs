using Archery.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Archery.Models
{
    public class Tournament
    {
        public int ID { get; set; }

        [Required]
        [Display(Name ="Nom")]
        public string Nom { get; set; }


        [Required]
        [Display(Name = "Date de départ")]
        [DataType(DataType.DateTime)]
        public DateTime? Start { get; set; }

        [Required]
        [Display(Name = "Date de fin")]
        [DataType(DataType.DateTime)]
        public DateTime? Finish { get; set; }

        [Required]
        [Display(Name ="Lieu")]
        [StringLength(250)]
        [DataType(DataType.MultilineText)]
        public string Location { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Nombre d'archer max")]
        public int MaxCapacity { get; set; }

        [Display(Name ="Prix")]
        public decimal? Fee { get; set; }

        [Display(Name ="Armes")]
        public ICollection<Weapon> Weapons { get; set; }

        public ICollection<Shooter> Participants { get; set; }
    }
}