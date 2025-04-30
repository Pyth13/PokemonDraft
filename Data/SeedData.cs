using Microsoft.EntityFrameworkCore;
using PokemonDraft.Models;
using System.IO;
using PokemonDraft.Models.Entities;
using System.Reflection.Emit;
using System.Diagnostics;

namespace PokemonDraft.Data;

public class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        /*using var context = new PokemonDraftContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<PokemonDraftContext>>());

        if (context == null || context.Pokedex == null)
        {
            throw new NullReferenceException(
                "Null PokemonDraftContext or Pokedex DbSet");
        }*/

        /*if (context.Pokedex.Any())
        {
            return;
        }*/

        /*if (context.Rosters.Any())
        {
            return;
        }

        var demoRoster = new Roster[]
        {
            new() {Id = 1, TeamOwner = "Pyth", TeamName = "Spiteful Sableyes", Mega = "Sableye", TierOneA = "Tornadus-T",
                TierOneB = "Clefable", TierTwoA = "Zygarde-50%", TierTwoB = "Metagross", TierThreeA = "Slowking",
                TierThreeB = "Tangrowth", TierFourA = "Salazzle", TierFourB = "Tsareena", TierFiveA = "Grafaiai",
                TierFiveB = "Togedemaru", TradeA = "Quagsire"},
            new() {Id = 2, TeamOwner = "Inuktitut", TeamName = "North Bay Nickits", Mega = "Charizard-Y", TierOneA = "Great Tusk",
                TierOneB = "Tapu Lele", TierTwoA = "Jirachi", TierTwoB = "H-Samurott", TierThreeA = "H-Zoroark",
                TierThreeB = "Crobat", TierFourA = "Tinkaton", TierFourB = "Gastrodon", TierFiveA = "Rotom-F",
                TierFiveB = "Leafeon", TradeA = "Latias", TradeB = "Zeraora", TradeC = "Whimsicott"},
        };
        context.Rosters.Add(new Roster
        {
            Id = 1,
            TeamOwner = "Pyth",
            TeamName = "Spiteful Sableyes",
            Mega = "Sableye",
            TierOneA = "Tornadus-T",
            TierOneB = "Clefable",
            TierTwoA = "Zygarde-50%",
            TierTwoB = "Metagross",
            TierThreeA = "Slowking",
            TierThreeB = "Tangrowth",
            TierFourA = "Salazzle",
            TierFourB = "Tsareena",
            TierFiveA = "Grafaiai",
            TierFiveB = "Togedemaru",
            TradeA = "Quagsire"
        });

        context.Rosters.Add(new Roster
        {
            Id = 2,
            TeamOwner = "Inuktitut",
            TeamName = "North Bay Nickits",
            Mega = "Charizard-Y",
            TierOneA = "Great Tusk",
            TierOneB = "Tapu Lele",
            TierTwoA = "Jirachi",
            TierTwoB = "H-Samurott",
            TierThreeA = "H-Zoroark",
            TierThreeB = "Crobat",
            TierFourA = "Tinkaton",
            TierFourB = "Gastrodon",
            TierFiveA = "Rotom-F",
            TierFiveB = "Leafeon",
            TradeA = "Latias",
            TradeB = "Zeraora",
            TradeC = "Whimsicott"
        });*/


        //modelBuilder.Entity<Roster>().HasData(demoRoster);

        /*string filePath = @"C:\Users\mrdsc\source\repos\PokemonDraft\Data\Pokedex.csv";
        if (File.Exists(filePath))
        {
            var lines = File.ReadAllLines(filePath);
            var dbset = new List<Pokedex>();
                foreach (var line in lines.Skip(1))
                {
                    var linePieces = line.Split(',');
                    dbset.Add(new Pokedex(linePieces));
                }
                context.Pokedex.AddRange(dbset);
                context.SaveChanges();
        }
        else
        {
            Console.WriteLine("file doesn't exist");
        }*/
    }
}