

namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Pessoa
    {

        //Propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Cargo { get; set; }
        public int Senha { get; set; }

        //Construtor
        public Pessoa(string nome, string usuario, string cargo, int senha)
        {
            Nome = nome;
            Usuario = usuario;
            Cargo = cargo;
            Senha = senha;
        }


    }
}
