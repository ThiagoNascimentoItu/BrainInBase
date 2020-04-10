using BrainInBaseClass.Instituicoes;
using BrainInBaseClass.Registros;
using BrainInBaseClass.Shared;
using BrainInBaseClass.Usuarios;
using Microsoft.EntityFrameworkCore;

namespace BrainInBaseApi.Context
{
    public class BrainInBaseContext : DbContext
    {
        public BrainInBaseContext(DbContextOptions<BrainInBaseContext> options) : base(options) { }

        public DbSet<Instituicao> Instituicao {get;set;}
        public DbSet<Registro> Registro { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Arquivo> Arquivo { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
    }
}
