using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Klinika.Data.Data.Acount
{
    public class Role
    {
        [Key]
        public int IdRole { get; set; }
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        public string Nazwa { get; set; }
        public List<User> User { get; set; }
    }
}
