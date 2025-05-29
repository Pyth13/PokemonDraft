using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.SqlServer.Management.Smo;

namespace PokemonDraft.Models.Entities;

public class DraftStats
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("pick")]
    [MaxLength(10)]
    public int Pick { get; set; }

    [Column("round")]
    [MaxLength(10)]
    public int Round { get; set; }

    [Column("pokemon")]
    [MaxLength(50)]
    public string? Pokemon { get; set; }

    [Column("owner")]
    [MaxLength(50)]
    public string? Owner { get; set; }

    [Column("tier")]
    [MaxLength(10)]
    public string? Tier { get; set; }

    [Column("timestamp")]
    [MaxLength(7)]
    public DateTime Timestamp { get; set; }
}
