using EasyCrud.Domain.Entities;
using EasyCrud.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace EasyCrud.Context
{
    public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
		public ApplicationDbContext() { }

		public DbSet<Candidate> Candidates { get; set; }

		public DbSet<Knowledge> Knowledges { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
           
            base.OnModelCreating(modelBuilder);
            new CandidateMapping(modelBuilder.Entity<Candidate>());
            new KnowledgeMapping(modelBuilder.Entity<Knowledge>());
		}

		public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return await base.SaveChangesAsync(cancellationToken);
		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
