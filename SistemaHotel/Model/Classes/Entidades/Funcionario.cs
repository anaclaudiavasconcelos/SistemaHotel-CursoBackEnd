

namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Funcionario
    {
        //Propriedade
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Cargo { get; set; }
        //Construtor
        public Funcionario(string nome, string endereco, string telefone, string cpf, string cargo)
        {
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Cpf = cpf;
            Cargo = cargo;
        }
    }
}
