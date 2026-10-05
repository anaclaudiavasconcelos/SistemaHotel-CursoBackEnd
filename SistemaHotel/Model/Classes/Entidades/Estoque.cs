using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaHotel.Model.Classes.Entidades
{
    internal class Estoque
    {
        public int id { get; set; }
        public int Produto { get; set; }
        public int fornecedor { get; set; }
        public int estoque { get; set; }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
    }
}
