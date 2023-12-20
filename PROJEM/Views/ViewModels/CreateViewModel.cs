using System.ComponentModel.DataAnnotations;

namespace PROJEM.ViewModels
{
    public class CreateViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı zorunludur.")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = " Ad Soyad zorunludur.")]
        public string FullName { get; set; } = string.Empty;

        [Required(ErrorMessage = "E-posta adresi zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Parola zorunludur.")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Parola tekrarı zorunludur.")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "Parola eşleşmiyor.")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
