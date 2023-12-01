using Microsoft.EntityFrameworkCore;
using ProjetoRotina.BackEnd.Entidades;

namespace ProjetoRotina.BackEnd.Repositorio
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rotina> Rotinas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=root;Database=ProjetoRotina;Integrated Security=true;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rotina>().HasMany<RotinaRealizada>().WithOne();
            base.OnModelCreating(modelBuilder);
        }
    }
}
