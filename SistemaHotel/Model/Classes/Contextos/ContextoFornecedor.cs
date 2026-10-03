using Microsoft.EntityFrameworkCore;

using SistemaHotel.Model.Classes.Entidades;

namespace SistemaHotel.Model.Classes.Contextos
{
    internal class ContextoFornecedor : DbContext
    {
        //Propriedade
        public DbSet<Fornecedor> fornecedor { get; set; }


        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = @"Server=ECFP507D1319371\SQLEXPRESS03;Database=SistemaHotel;Trusted_Connection=True;TrustServerCertificate=True";
            opcoesDeConstrucao.UseSqlServer(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Fornecedor>(entidade =>
            {
                entidade.HasKey(e => e.Nome);

                entidade.Property(e => e.Endereco);

                entidade.Property(e => e.Telefone);


            }

        );
        }


    }
}
