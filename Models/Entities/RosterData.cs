using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonDraft.Models.Entities;

public class Roster()
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("team_owner")]
    [MaxLength(50)]
    public string? TeamOwner { get; set; }

    [Column("team_name")]
    [MaxLength(50)]
    public string? TeamName { get; set; }

    [Column("mega")]
    [MaxLength(50)]
    public string? Mega { get; set; }

    [Column("tier_one_a")]
    [MaxLength(50)]
    public string? TierOneA { get; set; }

    [Column("tier_one_b")]
    [MaxLength(50)]
    public string? TierOneB { get; set; }

    [Column("tier_two_a")]
    [MaxLength(50)]
    public string? TierTwoA { get; set; }

    [Column("tier_two_b")]
    [MaxLength(50)]
    public string? TierTwoB { get; set; }

    [Column("tier_three_a")]
    [MaxLength(50)]
    public string? TierThreeA { get; set; }

    [Column("tier_three_b")]
    [MaxLength(50)]
    public string? TierThreeB { get; set; }

    [Column("tier_four_a")]
    [MaxLength(50)]
    public string? TierFourA { get; set; }

    [Column("tier_four_b")]
    [MaxLength(50)]
    public string? TierFourB { get; set; }

    [Column("tier_five_a")]
    [MaxLength(50)]
    public string? TierFiveA { get; set; }

    [Column("tier_five_b")]
    [MaxLength(50)]
    public string? TierFiveB { get; set; }

    [Column("trade_a")]
    [MaxLength(50)]
    public string? TradeA { get; set; }

    [Column("trade_b")]
    [MaxLength(50)]
    public string? TradeB { get; set; }

    [Column("trade_c")]
    [MaxLength(50)]
    public string? TradeC { get; set; }

    [Column("trade_d")]
    [MaxLength(50)]
    public string? TradeD { get; set; }

    [Column("trade_e")]
    [MaxLength(50)]
    public string? TradeE { get; set; }

    [Column("trade_f")]
    [MaxLength(50)]
    public string? TradeF { get; set; }

    [Column("trade_g")]
    [MaxLength(50)]
    public string? TradeG { get; set; }

    [Column("trade_h")]
    [MaxLength(50)]
    public string? TradeH { get; set; }

    [Column("trade_i")]
    [MaxLength(50)]
    public string? TradeI { get; set; }

    [Column("trade_j")]
    [MaxLength(50)]
    public string? TradeJ { get; set; }

    [Column("pick_number")]
    [MaxLength(10)]
    public int PickNumber { get; set; }

    [Column("gp")]
    [MaxLength(10)]
    public int Gp { get; set; }

    [Column("wins")]
    [MaxLength(10)]
    public int Wins { get; set; }

    [Column("losses")]
    [MaxLength(10)]
    public int Losses { get; set; }

    [Column("wl")]
    [MaxLength(10)]
    public int Wl { get; set; }

    [Column("kos")]
    [MaxLength(10)]
    public int Kos { get; set; }

    [Column("deaths")]
    [MaxLength(10)]
    public int Deaths { get; set; }

    [Column("plus_minus")]
    [MaxLength(10)]
    public int PlusMinus { get; set; }

    [Column("opp_plus_minus")]
    [MaxLength(10)]
    public int OppPlusMinus { get; set; }
}