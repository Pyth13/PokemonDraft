using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonDraft.Models.Entities;

[Table("user_account")]
public class UserAccount
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("user_name")]
    [MaxLength(50)]
    public string? UserName { get; set; }

    [Column("password")]
    [MaxLength(500)]
    public string? Password { get; set; }

    [Column("team")]
    [MaxLength(10)]
    public string? Team { get; set; }
}
