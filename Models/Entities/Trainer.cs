using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonDraft.Models.Entities;

[Table("Trainer")]
public class Trainer
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("TrainerName")]
    [MaxLength(50)]
    public string? TrainerName { get; set; }

    [Column("RosterId")]
    [MaxLength(500)]
    public int RosterId { get; set; }

    [Column("Password")]
    [MaxLength(50)]
    public string? Password { get; set; }
}
