using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Klinika.Intranet.Models.CMS
{
    public class Parametry
    {
        [Key]
        public int IdParametru { get; set; }

        //[Required(ErrorMessage = "Kod jest wymagany")]
        //[MaxLength(10, ErrorMessage = "Kod powinien zawierać max 10 znaków")]
        //public string Kod { get; set; }

        [Required(ErrorMessage = "Nazwa jest wymagany")]
        [MaxLength(50, ErrorMessage = "Nazwa powinien zawierać max 30 znaków")]
        public string Nazwa { get; set; }

        //[Required(ErrorMessage = "Wartość jest wymagany")]
        //[Display(Name = "Wartość")]
        //public string Wartosc { get; set; }
        [Required(ErrorMessage = "Opis jest wymagany")]
        public string Opis { get; set; }
        public bool CzyAktywny { get; set; }
    }
}
