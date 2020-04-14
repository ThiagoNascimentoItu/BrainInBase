using BrainInBaseApi.Context.BrainEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BrainInBaseApi.Context
{
    public class BrainInBaseContext : DbContext
    {
        public BrainInBaseContext(DbContextOptions<BrainInBaseContext> options) : base(options) { }

        public DbSet<UsuariosEntity> Usuarios { get; set; }
        public DbSet<EmissorEntity> Emissor { get; set; }
        public DbSet<RegistrosEntity> Registros { get; set; }
        public DbSet<EnderecoEntity> Endereco { get; set; }
        public DbSet<ComprovantesEntity> Comprovantes { get; set; }
        public DbSet<RegistrosEmissorEntity> RegistrosEmissor { get; set; }
        public DbSet<UsuariosComprovantesEntity> UsuariosComprovantes { get; set; }
        public DbSet<UsuariosRegistrosEntity> UsuariosRegistros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UsuariosEntity>().ToTable("Usuarios").
                Property(u => u.Codigo).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            modelBuilder.Entity<RegistrosEntity>().ToTable("Registros")
                .Property(u => u.Codigo).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            modelBuilder.Entity<EmissorEntity>().ToTable("Emissor")
                .Property(u => u.Codigo).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            modelBuilder.Entity<ComprovantesEntity>().ToTable("Comprovantes")
               .Property(u => u.Codigo).Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            modelBuilder.Entity<EnderecoEntity>().ToTable("Endereco");
            modelBuilder.Entity<RegistrosEmissorEntity>().ToTable("RegistrosEmissor");
            modelBuilder.Entity<UsuariosComprovantesEntity>().ToTable("UsuariosComprovantes");
            modelBuilder.Entity<UsuariosRegistrosEntity>().ToTable("UsuariosRegistros");

        }
    }

}
