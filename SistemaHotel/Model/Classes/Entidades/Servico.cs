

namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Servico
    {
        //Propriedades
        public int Id { get; set; }
        public string NomeServico { get; set; }
        public decimal ValorServico { get; set; }

        //Construtor
        public Servico(string nomeServico, decimal valorServico)
        {
            NomeServico = nomeServico;
            ValorServico = valorServico;
        }

    }
}
