// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Addresses.Cities.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Addresses.StateCities.DatabaseContext
{
    /// <summary>EntityFrameworkCore database context for StateCity entities</summary>
    public class StateCityDbContext : CityDbContext
    {
        /// <summary>Constructs StateCityDbContext EntityFrameworkCore database context using given options</summary>
        public StateCityDbContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>Contains set of StateCity entities</summary>
        public DbSet<StateCity> StateCities { get; set; }

        /// <summary>Configures EntityFramework database creation - adds unique index to model</summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StateCity>().HasIndex(new StateCity().GetUniqueIndex()).IsUnique();
        }
    }
}
