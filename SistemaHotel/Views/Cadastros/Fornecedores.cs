
using SistemaHotel.Model.Classes.Contextos;
using SistemaHotel.Model.Classes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.Cadastros
{
    public partial class FrmFornecedores : Form
    {


        string id;

        public FrmFornecedores()
        {
            InitializeComponent();
        }


        private void FormatarDG()
        {

        }

        private void Listar()
        {
            var contexto = new ContextoFornecedor();
            grid.DataSource = contexto.fornecedor.ToList();



            FormatarDG();
        }


        private void BuscarNome()
        {
            ContextoFornecedor contexto = new ContextoFornecedor();
            var lista = contexto.fornecedor.ToList();
            if (txtBuscarNome.Text != "")
            {
                grid.DataSource = lista.Where(x => x.Nome.Contains(txtBuscarNome.Text)).ToList();
            }
            else
            {
                grid.DataSource = lista;
            }

            FormatarDG();
        }


        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            
            txtEndereco.Enabled = true;
           
            txtTelefone.Enabled = true;
            txtNome.Focus();

        }


        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            
            txtEndereco.Enabled = false;
            
            txtTelefone.Enabled = false;
        }


        private void limparCampos()
        {
            txtNome.Text = "";
            
            txtEndereco.Text = "";
            txtTelefone.Text = "";
        }


        private void FrmFornecedores_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
          
            habilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }




            //CÓDIGO DO BOTÃO PARA SALVAR
            
            var fornecedor = new Fornecedor(txtNome.Text, txtEndereco.Text, txtTelefone.Text);
            var contexto = new ContextoFornecedor();
            contexto.fornecedor.Add(fornecedor);
            contexto.SaveChanges();


            grid.DataSource = contexto.fornecedor.Select(x => new
            {
                x.Id,
                x.Nome,
                x.Endereco,
                x.Telefone
            }).ToList();
            grid.Columns[0].HeaderText = "Código";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "Endereço";
            grid.Columns[3].HeaderText = "Telefone";
            

            MessageBox.Show("Registro Salvo com Sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();
            Listar();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            habilitarCampos();

            id = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
           
            txtEndereco.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtTelefone.Text = grid.CurrentRow.Cells[3].Value.ToString();
           

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus();
                return;
            }




            //CÓDIGO DO BOTÃO PARA EDITAR

            var contexto = new ContextoFornecedor();
            contexto.fornecedor.FirstOrDefault(x => x.Id.ToString() == id).Nome = txtNome.Text;
            contexto.fornecedor.FirstOrDefault(x => x.Id.ToString() == id).Endereco = txtEndereco.Text;
            contexto.fornecedor.FirstOrDefault(x => x.Id.ToString() == id).Telefone = txtTelefone.Text;
            contexto.SaveChanges();


            MessageBox.Show("Registro Editado com Sucesso!", "Dados Editados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            limparCampos();
            desabilitarCampos();
            Listar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja Realmente Excluir o Registro?", "Excluir Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                //CÓDIGO DO BOTÃO PARA EXCLUIR
                var contexto = new ContextoFornecedor();
                contexto.fornecedor.Remove(contexto.fornecedor.FirstOrDefault(x => x.Id.ToString() == id));
                contexto.SaveChanges();

                MessageBox.Show("Registro Excluido com Sucesso!", "Registro Excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                limparCampos();
                desabilitarCampos();
                
                Listar();
            }
        }

        private void TxtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }
    }
}
