using System.ComponentModel.DataAnnotations;

namespace GirisSayfaMVC.Models
{
    public class Login
    {
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir E-Posta adresi giriniz.")]
        [Display(Name ="E-posta")]
        [Required(ErrorMessage = "E-posta adresinizi giriniz.")]
        public string Eposta{ get; set; }


        [Display(Name ="Şifre")]
        [Required(ErrorMessage = "Şifrenizi girin.")]
        public string Password{ get; set; }
    }
}
