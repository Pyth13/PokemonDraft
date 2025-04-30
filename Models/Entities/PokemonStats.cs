using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonDraft.Models.Entities;

public class PokemonStats
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("team")]
    [MaxLength(50)]
    public string? Team { get; set; }

    [Column("pick")]
    [MaxLength(50)]
    public string? Pick { get; set; }

    [Column("tier")]
    [MaxLength(50)]
    public string? Tier { get; set; }

    [Column("gp")]
    [MaxLength(50)]
    public string? Gp { get; set; }

    [Column("kos")]
    [MaxLength(50)]
    public string? Kos { get; set; }

    [Column("deaths")]
    [MaxLength(50)]
    public string? Deaths { get; set; }

    [Column("plus_minus")]
    [MaxLength(50)]
    public string? PlusMinus { get; set; }

    [Column("multi_kill")]
    [MaxLength(50)]
    public string? MultiKill { get; set; }

    [Column("max_kill")]
    [MaxLength(50)]
    public string? MaxKill { get; set; }
}

