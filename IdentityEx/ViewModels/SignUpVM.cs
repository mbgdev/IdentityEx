using System.ComponentModel.DataAnnotations;

namespace IdentityEx.ViewModels
{
    public class SignUpVM
    {
      
        [Required(ErrorMessage ="{0} alanı boş geçilemez.")]
        [Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [EmailAddress(ErrorMessage = "{0} geçerli bir e-posta formatı giriniz.")]
        [Display(Name = "E-Posta :")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [Display(Name = "Telefon :")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [Display(Name = "Şifre :")]
        public string Password { get; set; }

        [Required(ErrorMessage = "{0} alanı boş geçilemez.")]
        [Display(Name = "Şifre Tekrar :")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor.")]
        public string PasswordConfirm { get; set; }


    }
}
