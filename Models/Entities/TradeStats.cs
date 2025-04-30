using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonDraft.Models.Entities;

public class TradeStats
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("trade_team")]
    [MaxLength(50)]
    public string? TradeTeam { get; set; }

    [Column("trade_previous_team")]
    [MaxLength(50)]
    public string? TradePreviousTeam { get; set; }

    [Column("trade_tier")]
    [MaxLength(50)]
    public string? TradeTier { get; set; }

    [Column("trade_pick")]
    [MaxLength(50)]
    public string? TradePick { get; set; }

    [Column("trade_gp")]
    [MaxLength(50)]
    public string? TradeGp { get; set; }

    [Column("trade_k")]
    [MaxLength(50)]
    public string? TradeKos { get; set; }

    [Column("trade_d")]
    [MaxLength(50)]
    public string? TradeDeaths { get; set; }

    [Column("trade_plus_minus")]
    [MaxLength(50)]
    public string? TradePlusMinus { get; set; }

    [Column("trade_multi_kill")]
    [MaxLength(50)]
    public string? TradeMultiKill { get; set; }

    [Column("trade_max_kill")]
    [MaxLength(50)]
    public string? TradeMaxKill { get; set; }
}
