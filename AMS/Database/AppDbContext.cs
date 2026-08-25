using Microsoft.EntityFrameworkCore;
using AMS.Entities;

namespace AMS.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Accession> Acessions { get; set; }
        public DbSet<AccessionSource> AccessionSources { get; set; }
        public DbSet<Cooperator> Cooperators { get; set; }
        public DbSet<Descriptor> Descriptors { get; set; }
        public DbSet<FireblightRating> FireblightRatings { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Ipr> Iprs { get; set; }
        public DbSet<Narrative> Narratives { get; set; }
        public DbSet<Pedigree> Pedigrees { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Taxon> Taxons { get; set; }
    }
}
