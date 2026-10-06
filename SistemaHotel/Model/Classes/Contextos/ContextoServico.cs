using Microsoft.EntityFrameworkCore;
using SistemaHotel.Model.Classes.Entidades;
using System;


namespace SistemaHotel.Model.Classes.Contextos
{
    internal class ContextoServico : DbContext
    {
        //Propriedade
        public DbSet<Servico> servico { get; set; }

        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = Environment.GetEnvironmentVariable("db1");
            opcoesDeConstrucao.UseSqlServer(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Servico>(entidade =>
            {
                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.NomeServico);

                entidade.Property(e => e.ValorServico);


            }

        );

        }
    }
}
