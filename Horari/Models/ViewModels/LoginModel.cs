using System.ComponentModel.DataAnnotations;

namespace Horari.Models.ViewModels
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Usuario")]
        public string Control { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Passwd { get; set; }
    }
}