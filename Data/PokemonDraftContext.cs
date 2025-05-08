using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PokemonDraft.Models;
using PokemonDraft.Models.Entities;

namespace PokemonDraft.Data
{
    public class PokemonDraftContext(DbContextOptions<PokemonDraftContext> options) : DbContext(options)
    {
        public DbSet<PokemonDraft.Models.Pokedex> Pokedex { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var demoUserAccounts = new Trainer[]
            {
                new() {Id = 1, TrainerName = "guest", Password = "guest1"},
                new() {Id = 2, TrainerName = "player", Password = "player1"},
                new() {Id = 3, TrainerName = "admin", Password = "admin1"}
            };
            modelBuilder.Entity<UserAccount>().HasData(demoUserAccounts);

            var demoUserAccountPolicies = new UserAccountPolicy[]
            {
                new() {Id = 1, UserAccountId = 1, UserPolicy = UserPolicy.VIEW_PRODUCT.ToString(), IsEnabled=false},
                new() {Id = 2, UserAccountId = 1, UserPolicy = UserPolicy.ADD_PRODUCT.ToString(), IsEnabled=false},
                new() {Id = 3, UserAccountId = 1, UserPolicy = UserPolicy.EDIT_PRODUCT.ToString(), IsEnabled=false},
                new() {Id = 4, UserAccountId = 1, UserPolicy = UserPolicy.DELETE_PRODUCT.ToString(),IsEnabled=false},

                new() {Id = 5, UserAccountId = 2, UserPolicy = UserPolicy.VIEW_PRODUCT.ToString(),IsEnabled=true},
                new() {Id = 6, UserAccountId = 2, UserPolicy = UserPolicy.ADD_PRODUCT.ToString(), IsEnabled=false},
                new() {Id = 7, UserAccountId = 2, UserPolicy = UserPolicy.EDIT_PRODUCT.ToString(), IsEnabled=false},
                new() {Id = 8, UserAccountId = 2, UserPolicy = UserPolicy.DELETE_PRODUCT.ToString(),IsEnabled=false},

                new() {Id = 9, UserAccountId = 3, UserPolicy = UserPolicy.VIEW_PRODUCT.ToString(),IsEnabled=true},
                new() {Id = 10, UserAccountId = 3, UserPolicy = UserPolicy.ADD_PRODUCT.ToString(), IsEnabled=true},
                new() {Id = 11, UserAccountId = 3, UserPolicy = UserPolicy.EDIT_PRODUCT.ToString(), IsEnabled=true},
                new() {Id = 12, UserAccountId = 3, UserPolicy = UserPolicy.DELETE_PRODUCT.ToString(),IsEnabled=true},
            };
            modelBuilder.Entity<UserAccountPolicy>().HasData(demoUserAccountPolicies);

            var demo
                
                = new Roster[]
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
            //modelBuilder.Entity<Roster>().HasData(demoRoster);
            
        }

        //this might be fucked, merge with Pokempublic DbSet<Product> Products { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<UserAccountPolicy> UserAccountsPolicies { get; set; }
        public DbSet<Roster> Rosters { get; set; }
        public DbSet<PokemonStats> PokemonStats { get; set; }
        public DbSet<TradeStats> TradeStats { get; set; }
        public DbSet<DraftStats> DraftStats { get; set; }
        public DbSet<Trainer> Trainer {  get; set; }
    }
}
