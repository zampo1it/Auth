using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;

namespace WebApp5.ViewModel
{
    public class Login
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
