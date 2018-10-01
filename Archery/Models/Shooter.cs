using Archery.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Archery.Models
{
    public class Shooter
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Tournoi")]
        public int TournamentID { get; set; }

        [ForeignKey("TournamentID")]
        public Tournament Tournament { get; set; }

        [Required]
        [Display(Name = "Arme")]
        public int WeaponID { get; set; }

        [ForeignKey("WeaponID")]
        public Weapon Weapon { get; set; }

        [Required]
        [Display(Name = "Archer")]
        public int ArcherID { get; set; }

        [ForeignKey("ArcherID")]
        public Archer Archer { get; set; }

        public DateTime? Departure { get; set; }
    }
}