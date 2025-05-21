using Microsoft.AspNetCore.Identity;


namespace PokemonDraft.Data
{
    public class User : IdentityUser
    {
        public string Role { get; set; }
    }
}
