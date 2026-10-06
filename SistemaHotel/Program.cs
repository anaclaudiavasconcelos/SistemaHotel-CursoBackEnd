using Microsoft.EntityFrameworkCore;
using SistemaHotel.Model.Classes.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    static class Program
    {
        //DECLARAR AS VARIAVEIS GLOBAIS DO SISTEMA
        public static string nomeUsuario;
        public static string cargoUsuario;
        public static string chamadaProdutos;
        public static string nomeProduto;
        public static string estoqueProduto;
        public static string idProduto;
        //private static List<DbContext> listaContextos = new List<DbContext>();

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmMenu());
            Application.Run(new FrmLogin());


            /*listaContextos.Add(new ContextoFornecedor());
            listaContextos.Add(new ContextoPessoa());
            listaContextos.Add(new ContextoCargo());
            listaContextos.Add(new ContextoFuncionario());
            listaContextos.Add(new ContextoServico());


            foreach (var item in listaContextos)
            {
                item.Database.EnsureCreated();
                MessageBox.Show($"Banco de dados {item.GetType().Name} criado com sucesso!");
            }



            if (TestarConexaoBanco())
            {
                MessageBox.Show("Conexão realizada com sucesso!");
                Application.Run(new FrmLogin());
                //Application.Run(new FrmMenu());


            }
            else
            {
                MessageBox.Show("Falha ao conectar ao banco de dados");
            }

        }

        private static bool TestarConexaoBanco()
        {
            try
            {
                foreach (var item in listaContextos)
                {
                    bool teste = item.Database.CanConnect();
                    if (!teste)
                    {
                        return false;
                    }            
                }

                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro: {e.Message} ");
                return false;
            }
        }*/
        }
    }
}
        
    
