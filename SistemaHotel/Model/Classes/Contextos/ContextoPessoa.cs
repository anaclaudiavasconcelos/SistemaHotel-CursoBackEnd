using Microsoft.EntityFrameworkCore;
using SistemaHotel.Model.Classes.Entidades;

namespace SistemaHotel.Model.Classes.Contextos
{
    internal class ContextoPessoa : DbContext
    {
        //Propriedade
        public DbSet<Pessoa> pessoa { get; set; }

       

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=ECFP507D1319371\SQLEXPRESS03;Database=SistemaHotel;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Pessoa>(entidade =>
            {
                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.Nome);
                entidade.Property(e => e.Usuario);
                entidade.Property(e => e.Cargo);
                entidade.Property(e => e.Senha);

            }

        );
        }

    }
}
