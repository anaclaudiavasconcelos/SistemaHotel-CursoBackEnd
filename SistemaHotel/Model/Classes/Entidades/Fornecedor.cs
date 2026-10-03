

namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Fornecedor
    {
        //Propriedade
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Telefone { get; set; }

        //Construtor

        public Fornecedor(string nome, string endereco, int telefone)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
        }
    }
}
