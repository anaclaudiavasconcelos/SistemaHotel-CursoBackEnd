
namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Cargo
    {
        //Propriedades
        public int Id { get; set; }
        public string NomeDoCargo { get; set; }

        //Construtor
        public Cargo(string nomeDoCargo)
        {
            NomeDoCargo = nomeDoCargo;
        }


    }
}
