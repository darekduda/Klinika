using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Klinika.Data.Data.Wizyty
{
    public class RodzajeWizyt
    {
        [Key]
        public int IdRodzajeWizyty { get; set; }
        public string Nazwa { get; set; }
    }
}
