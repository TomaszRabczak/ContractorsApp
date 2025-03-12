using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore;
using Contractors.Contracts.Models;
using Microsoft.Extensions.Configuration;

namespace Contractors.DatabaseCore
{
    public class ContractorsDbContext : DbContext
    {
        public DbSet<Contractor> Contractors { get; set; } = default!;
        public DbSet<ContractorAddress> ContractorAddresses { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Contractor>()
                .Property(e => e.Nip)
                .IsUnicode(false);

            modelBuilder
                .Entity<Contractor>()
                .Property(e => e.Regon)
                .IsUnicode(false);

            modelBuilder
                .Entity<ContractorAddress>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                            .SetBasePath(Directory.GetCurrentDirectory())
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            var configuration = builder.Build();
            var cnstr = configuration.GetConnectionString("ContractorsDb");

            optionsBuilder.UseSqlServer(cnstr);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Conventions.Remove(typeof(TableNameFromDbSetConvention));
        }

        public async override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetAuditData();
            return await base.SaveChangesAsync();
        }

        private void SetAuditData()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is AuditModel referenceEntity)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            referenceEntity.CreatedDate = DateTime.UtcNow;
                            break;
                        case EntityState.Modified:
                            referenceEntity.LastModifiedDate = DateTime.UtcNow;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
