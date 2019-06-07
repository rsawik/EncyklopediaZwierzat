using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EncyklopediaZwierzat.ViewModels
{
    public class LoginVM
    {
        [Required]
        [Display(Name = "Nazwa Użytkownika")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Hasło Użytkownika")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
