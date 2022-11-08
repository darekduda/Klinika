using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Klinika.Data.Data.Acount
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        [Required(ErrorMessage = "Email jest wymagany")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Imie jest wymagane")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Nazwisko jest wymagane")]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Hasło jest wymagane")]
        public string PasswordHash { get; set; }
        public int IdRole { get; set; }
        public Role Role { get; set; }
    }
}
