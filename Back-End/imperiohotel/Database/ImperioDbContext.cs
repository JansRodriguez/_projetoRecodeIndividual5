using Microsoft.EntityFrameworkCore;
using imperiohotel.Model;

namespace imperiohotel.Database
{
    public class ImperioDbContext : DbContext
    {
        public ImperioDbContext(DbContextOptions<ImperioDbContext>
        options) : base(options)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var clientes = modelBuilder.Entity<Cliente>();
            clientes.ToTable("clientes");
            clientes.HasKey(x => x.Id);
            clientes.Property(x => x.IdCliente).HasColumnName("IdCliented").ValueGeneratedOnAdd();
            clientes.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            clientes.Property(x => x.email).HasColumnName("email").IsRequired();
        }

        public DbSet<Passagem> Passagens { get; set; }

        public DbSet<Promocoes> Promocoes { get; set; }

        public DbSet<ContatoReclamacao> ContatoReclamacao { get; set; }
    }
}