using System.ComponentModel.DataAnnotations;

namespace PROJEM.ViewModels
{
    public class EditViewModel
    {
        public string? Id { get; set; } 

        public string? FullName { get; set; } 


        public string? UserName { get; set; } 

        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string? Email { get; set; } 

        [DataType(DataType.Password)]
        public string? Password { get; set; } 

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Parola eşleşmiyor.")]
        public string? ConfirmPassword { get; set; } 

        public IList<string>? SelectedRoles {get;set;}
}
}