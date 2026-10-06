
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
    public partial class FrmFuncionarios : Form
    {


        string id;

        string cpfAntigo;

        public FrmFuncionarios()
        {
            InitializeComponent();
        }


        private void CarregarCombobox()
        {

        }


        private void FormatarDG()
        {

        }

        private void Listar()
        {
            var contexto = new ContextoFuncionario();
            grid.DataSource = contexto.funcionario.ToList();


            FormatarDG();
        }


        private void BuscarNome()
        {
            ContextoFuncionario contexto = new ContextoFuncionario();
            var lista = contexto.funcionario.ToList();
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


        private void BuscarCPF()
        {
            ContextoFuncionario contexto = new ContextoFuncionario();
            var lista = contexto.funcionario.ToList();
            if (txtBuscarCPF.Text != "")
            {
                grid.DataSource = lista.Where(x => x.Cpf.Contains(txtBuscarCPF.Text)).ToList();
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
            txtCPF.Enabled = true;
            txtEndereco.Enabled = true;
            cbCargo.Enabled = true;
            txtTelefone.Enabled = true;
            txtNome.Focus();

        }


        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtEndereco.Enabled = false;
            cbCargo.Enabled = false;
            txtTelefone.Enabled = false;
        }


        private void limparCampos()
        {
            txtNome.Text = "";
            txtCPF.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
        }




        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            Listar();
            rbNome.Checked = true;
            CarregarCombobox();
        }

        private void RbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarNome.Visible = true;
            txtBuscarCPF.Visible = false;

            txtBuscarNome.Text = "";
            txtBuscarCPF.Text = "";

        }

        private void RbCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarNome.Visible = false;
            txtBuscarCPF.Visible = true;

            txtBuscarNome.Text = "";
            txtBuscarCPF.Text = "";
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {

            if (cbCargo.Text == "")
            {
                MessageBox.Show("Cadastre Antes um Cargo!");
                Close();
            }

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

            if (txtCPF.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCPF.Focus();
                return;
            }


            //CÓDIGO DO BOTÃO PARA SALVAR
            var funcionario = new Funcionario(txtNome.Text, txtCPF.Text, txtEndereco.Text, cbCargo.Text, txtTelefone.Text);
            var contexto = new ContextoFuncionario();
            contexto.funcionario.Add(funcionario);
            contexto.SaveChanges();


            grid.DataSource = contexto.funcionario.Select(x => new
            {
                x.Id,
                x.Nome,
                x.Cpf,
                x.Endereco,
                x.Telefone
            }).ToList();
            grid.Columns[0].HeaderText = "Código";
            grid.Columns[1].HeaderText = "Nome";
            grid.Columns[2].HeaderText = "CPF";
            grid.Columns[3].HeaderText = "Endereço";
            grid.Columns[4].HeaderText = "Telefone";



            //VERIFICAR SE O CPF JÁ EXISTE NO BANCO
            string cpf = txtCPF.Text;


            if (cpf.Equals("123456"))
            {
                MessageBox.Show("CPF já Registrado!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCPF.Text = "";
                txtCPF.Focus();
                return;
            }



            MessageBox.Show("Registro Salvo com Sucesso!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();
            Listar();
        }

        private void Grid_Click(object sender, EventArgs e)
        {
           
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

            if (txtCPF.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCPF.Focus();
                return;
            }


            //CÓDIGO DO BOTÃO PARA EDITAR
            var contexto = new ContextoFuncionario();
            contexto.funcionario.FirstOrDefault(x => x.Id.ToString() == id).Nome = txtNome.Text;
            contexto.funcionario.FirstOrDefault(x => x.Id.ToString() == id).Cpf = txtCPF.Text;
            contexto.funcionario.FirstOrDefault(x => x.Id.ToString() == id).Endereco = txtEndereco.Text;
            contexto.funcionario.FirstOrDefault(x => x.Id.ToString() == id).Telefone = txtTelefone.Text;
            contexto.SaveChanges();



            //VERIFICAR SE O CPF JÁ EXISTE NO BANCO

            if (txtCPF.Text != cpfAntigo)
            {

                if (false) // Substitua 'false' pela condição real para verificar se o CPF existe no banco de dados.
                {
                    MessageBox.Show("CPF já Registrado!", "Dados Salvo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCPF.Text = "";
                    txtCPF.Focus();
                    return;
                }

            }




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
                var contexto = new ContextoFuncionario();
                contexto.funcionario.Remove(contexto.funcionario.FirstOrDefault(x => x.Id.ToString() == id));
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

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            habilitarCampos();

            id = grid.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = grid.CurrentRow.Cells[1].Value.ToString();
            txtCPF.Text = grid.CurrentRow.Cells[2].Value.ToString();
            txtEndereco.Text = grid.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = grid.CurrentRow.Cells[4].Value.ToString();
            cbCargo.Text = grid.CurrentRow.Cells[5].Value.ToString();
            
            cpfAntigo = grid.CurrentRow.Cells[2].Value.ToString();
        }

        private void TxtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            BuscarNome();
        }

        private void TxtBuscarCPF_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCPF.Text == "   .   .   -")
            {
                Listar();
            }
            else
            {
                BuscarCPF();
            }
                
        }
    }
}
