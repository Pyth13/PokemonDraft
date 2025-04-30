using System.ComponentModel.DataAnnotations;

namespace PokemonDraft.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your username")]
        public string? UserName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your password")]
        public string? Password { get; set; }
    }
}
