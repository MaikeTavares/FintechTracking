using Microsoft.EntityFrameworkCore;
using FintechTracking.Entites;
using System.Reflection.Metadata;

namespace FintechTrackingDb
{

    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> option) : base(option)
        {

        }
        public DbSet<FintechOnboardingTracking> FintechOnboardingTrackings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                ("Server=vector-staging.crq1x7r54196.sa-east-1.rds.amazonaws.com;Database=VECTOR_FINTECH_STAGING;User ID=s_cargo_stg_fintech;Password=l.L32ne6a721z;Application Name=IdentityProvider;");
        }

    }
}