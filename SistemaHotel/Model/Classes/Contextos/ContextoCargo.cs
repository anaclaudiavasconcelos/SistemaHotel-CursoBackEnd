

using Microsoft.EntityFrameworkCore;
using SistemaHotel.Model.Classes.Entidades;
using System;

namespace SistemaHotel.Model.Classes.Contextos
{
    internal class ContextoCargo : DbContext
    {
        //Propriedade
        public DbSet<Cargo> cargo { get; set; }


        //Métodos
        protected override void OnConfiguring(DbContextOptionsBuilder opcoesDeConstrucao)
        {
            string caminho = Environment.GetEnvironmentVariable("db1");
            opcoesDeConstrucao.UseSqlServer(caminho);
        }


        protected override void OnModelCreating(ModelBuilder modeloDeConstrucao)
        {
            modeloDeConstrucao.Entity<Cargo>(entidade =>
            {
                entidade.HasKey(e => e.Id);

                entidade.Property(e => e.NomeDoCargo);


            }

        );
        }
    }
}
