using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Klinika.Data.Data.CMS
{
    public class Aktualnosc
    {
        [Key]
        public int IdAktualnosci { get; set; }

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
