using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialRonaldVelasco.Models
{
    public class Language
    {
        [Key]
        [Required]
        public string Iso639_1 { get; set; }
        [Required]
        public string Iso639_2 { get; set; }
        [Required]
        public string NAME { get; set; }
        [Required]
        public string NativeName { get; set; }
    }
    public class Country
    {
        [Key]
        [Required]
        [StringLength(50, ErrorMessage = "Nombre Invalido", MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        public float Area { get; set; }
        [Required]
        [StringLength(3, ErrorMessage = "Nombre Invalido", MinimumLength = 3)]
        public string Alpha3Code { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Nombre Invalido", MinimumLength = 2)]
        public string Region { get; set; }
        [Required]
        public string CallingCodes { get; set; }
        [Required]
        public string Flag { get; set; }
        [Required]
        public List<Language> Languages { get; set; }
    }
}