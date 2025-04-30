using PokemonDraft.Models.Entities;
using Microsoft.EntityFrameworkCore;

/*woops this is all fuckin useless
 * 
 * namespace PokemonDraft.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var demoUserAccounts = new UserAccount[]
            {
                new UserAccount{Id = 1, UserName = "guest", Password = "guest1"},
                new UserAccount{Id = 2, UserName = "player", Password = "player1"},
                new UserAccount{Id = 3, UserName = "admin", Password = "admin1"}
            };
            modelBuilder.Entity<UserAccount>().HasData(demoUserAccounts);

            var demoUserAccountPolicies = new UserAccountPolicy[]
            {
                new UserAccountPolicy{Id = 1, UserAccountId = 1, UserPolicy = UserPolicy.VIEW_PRODUCT.ToString(), IsEnabled=false},
                new UserAccountPolicy{Id = 2, UserAccountId = 1, UserPolicy = UserPolicy.ADD_PRODUCT.ToString(), IsEnabled=false},
                new UserAccountPolicy{Id = 3, UserAccountId = 1, UserPolicy = UserPolicy.EDIT_PRODUCT.ToString(), IsEnabled=false},
                new UserAccountPolicy{Id = 4, UserAccountId = 1, UserPolicy = UserPolicy.DELETE_PRODUCT.ToString(),IsEnabled=false},

                new UserAccountPolicy{Id = 5, UserAccountId = 2, UserPolicy = UserPolicy.VIEW_PRODUCT.ToString(),IsEnabled=true},
                new UserAccountPolicy{Id = 6, UserAccountId = 2, UserPolicy = UserPolicy.ADD_PRODUCT.ToString(), IsEnabled=false},
                new UserAccountPolicy{Id = 7, UserAccountId = 2, UserPolicy = UserPolicy.EDIT_PRODUCT.ToString(), IsEnabled=false},
                new UserAccountPolicy{Id = 8, UserAccountId = 2, UserPolicy = UserPolicy.DELETE_PRODUCT.ToString(),IsEnabled=false},

                new UserAccountPolicy{Id = 9, UserAccountId = 3, UserPolicy = UserPolicy.VIEW_PRODUCT.ToString(),IsEnabled=true},
                new UserAccountPolicy{Id = 10, UserAccountId = 3, UserPolicy = UserPolicy.ADD_PRODUCT.ToString(), IsEnabled=true},
                new UserAccountPolicy{Id = 11, UserAccountId = 3, UserPolicy = UserPolicy.EDIT_PRODUCT.ToString(), IsEnabled=true},
                new UserAccountPolicy{Id = 12, UserAccountId = 3, UserPolicy = UserPolicy.DELETE_PRODUCT.ToString(),IsEnabled=true},
            };

            modelBuilder.Entity < UserAccountPolicy>().HasData(demoUserAccountPolicies);
        }

        //this might be fucked, merge with Pokempublic DbSet<Product> Products { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<UserAccountPolicy> UserAccountsPolicies { get; set; }
    }
}*/
