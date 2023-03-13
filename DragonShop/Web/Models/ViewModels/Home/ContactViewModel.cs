using System.ComponentModel.DataAnnotations;

namespace Web.Models.ViewModels.Home
{
    public sealed class ContactViewModel
    {
        [Required(ErrorMessage = "Имя должно быть от 3 до 32 символов!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "E-mail адрес введен неверно!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Длина текста должна быть от 10 до 3000 символов!")]
        public string Message { get; set; }
    }
}
