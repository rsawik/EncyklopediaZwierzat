using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace EncyklopediaZwierzat.Models
{
    public class Opinia
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage ="Nazwa użytkownika jest wymagana.")]
        public string NazwaUzytkownika { get; set; }
        [StringLength(66, ErrorMessage ="Email jest zbyt długi.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Wiadomość jest wymagana")]
        [StringLength(999,ErrorMessage ="Wiadomość jest zbyt długa.")]
        public string Wiadomosc { get; set; }
        public bool OczekujeOdpowiedzi { get; set; }
    }
}
