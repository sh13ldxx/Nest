using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModel.Auth
{
    public class RegisterVM
    {
        [Required, MaxLength(60)]
        public string FirstName { get; set; }
        [Required, MaxLength(60)]
        public string LastName { get; set; }
        [Required, MaxLength(80)]
        public string Username { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

    }
}
