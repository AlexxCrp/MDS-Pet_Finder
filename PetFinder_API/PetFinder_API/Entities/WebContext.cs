using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetFinder_API.Entities
{
    public class WebContext : IdentityDbContext<User, Role, string, IdentityUserClaim<string>,
        UserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public WebContext(DbContextOptions<WebContext> options) : base(options) { }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Proprietar> Proprietari { get; set; }
        public DbSet<Rasa> Rase { get; set; }
        public DbSet<IstoricMedical> IstoricMedicals { get; set; }
        public DbSet<Specie> Specii { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //One to One
            builder.Entity<Pet>()
                .HasOne(pet => pet.IstoricMedical)
                .WithOne(IstoricMedical => IstoricMedical.Pet);

            //One to Many
            builder.Entity<Rasa>()
                .HasMany(r => r.Pets)
                .WithOne(p => p.Rasa);

            builder.Entity<Specie>()
                .HasMany(s => s.Rase)
                .WithOne(r => r.Specie);

            builder.Entity<Proprietar>()
                .HasMany(p => p.Pets)
                .WithOne(pet => pet.Proprietar);

           
        }

    }
}
