namespace SistemaHotel
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            hóspedesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            quartosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            serviçosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            cargoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            novoProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuMovimentacoes = new System.Windows.Forms.ToolStripMenuItem();
            novaVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            novoServiçoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            entradasESaídasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuReservas = new System.Windows.Forms.ToolStripMenuItem();
            novaReservaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            quadroDeReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            consultarReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuChekInOut = new System.Windows.Forms.ToolStripMenuItem();
            novoServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            relátorio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlTopo = new System.Windows.Forms.Panel();
            button7 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            pnlRight = new System.Windows.Forms.Panel();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            lblUsuario = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            lblCargo = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            menuStrip1.SuspendLayout();
            pnlTopo.SuspendLayout();
            pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { MenuCadastro, MenuProdutos, MenuMovimentacoes, MenuReservas, MenuChekInOut, MenuRelatorios, MenuSair });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1197, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { funcionáriosToolStripMenuItem, hóspedesToolStripMenuItem, quartosToolStripMenuItem, usuáriosToolStripMenuItem, serviçosToolStripMenuItem, cargoToolStripMenuItem, fornecedoresToolStripMenuItem });
            MenuCadastro.Image = (System.Drawing.Image)resources.GetObject("MenuCadastro.Image");
            MenuCadastro.Name = "MenuCadastro";
            MenuCadastro.Size = new System.Drawing.Size(108, 24);
            MenuCadastro.Text = "Cadastros";
            // 
            // funcionáriosToolStripMenuItem
            // 
            funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            funcionáriosToolStripMenuItem.Text = "Funcionários";
            funcionáriosToolStripMenuItem.Click += FuncionáriosToolStripMenuItem_Click;
            // 
            // hóspedesToolStripMenuItem
            // 
            hóspedesToolStripMenuItem.Name = "hóspedesToolStripMenuItem";
            hóspedesToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            hóspedesToolStripMenuItem.Text = "Hóspedes";
            // 
            // quartosToolStripMenuItem
            // 
            quartosToolStripMenuItem.Name = "quartosToolStripMenuItem";
            quartosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            quartosToolStripMenuItem.Text = "Quartos";
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            usuáriosToolStripMenuItem.Text = "Usuários";
            usuáriosToolStripMenuItem.Click += UsuáriosToolStripMenuItem_Click;
            // 
            // serviçosToolStripMenuItem
            // 
            serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            serviçosToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            serviçosToolStripMenuItem.Text = "Serviços";
            serviçosToolStripMenuItem.Click += ServiçosToolStripMenuItem_Click;
            // 
            // cargoToolStripMenuItem
            // 
            cargoToolStripMenuItem.Name = "cargoToolStripMenuItem";
            cargoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            cargoToolStripMenuItem.Text = "Cargo";
            cargoToolStripMenuItem.Click += CargoToolStripMenuItem_Click;
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            fornecedoresToolStripMenuItem.Click += FornecedoresToolStripMenuItem_Click;
            // 
            // MenuProdutos
            // 
            MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { novoProdutoToolStripMenuItem, estoqueToolStripMenuItem });
            MenuProdutos.Image = (System.Drawing.Image)resources.GetObject("MenuProdutos.Image");
            MenuProdutos.Name = "MenuProdutos";
            MenuProdutos.Size = new System.Drawing.Size(102, 24);
            MenuProdutos.Text = "Produtos";
            // 
            // novoProdutoToolStripMenuItem
            // 
            novoProdutoToolStripMenuItem.Name = "novoProdutoToolStripMenuItem";
            novoProdutoToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            novoProdutoToolStripMenuItem.Text = "Novo Produto";
            novoProdutoToolStripMenuItem.Click += NovoProdutoToolStripMenuItem_Click;
            // 
            // estoqueToolStripMenuItem
            // 
            estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            estoqueToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            estoqueToolStripMenuItem.Text = "Estoque";
            estoqueToolStripMenuItem.Click += EstoqueToolStripMenuItem_Click;
            // 
            // MenuMovimentacoes
            // 
            MenuMovimentacoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { novaVendaToolStripMenuItem, novoServiçoToolStripMenuItem1, entradasESaídasToolStripMenuItem });
            MenuMovimentacoes.Image = (System.Drawing.Image)resources.GetObject("MenuMovimentacoes.Image");
            MenuMovimentacoes.Name = "MenuMovimentacoes";
            MenuMovimentacoes.Size = new System.Drawing.Size(148, 24);
            MenuMovimentacoes.Text = "Movimentações";
            // 
            // novaVendaToolStripMenuItem
            // 
            novaVendaToolStripMenuItem.Name = "novaVendaToolStripMenuItem";
            novaVendaToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            novaVendaToolStripMenuItem.Text = "Nova Venda";
            // 
            // novoServiçoToolStripMenuItem1
            // 
            novoServiçoToolStripMenuItem1.Name = "novoServiçoToolStripMenuItem1";
            novoServiçoToolStripMenuItem1.Size = new System.Drawing.Size(208, 26);
            novoServiçoToolStripMenuItem1.Text = "Novo Serviço";
            // 
            // entradasESaídasToolStripMenuItem
            // 
            entradasESaídasToolStripMenuItem.Name = "entradasESaídasToolStripMenuItem";
            entradasESaídasToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            entradasESaídasToolStripMenuItem.Text = "Entradas e Saídas";
            // 
            // MenuReservas
            // 
            MenuReservas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { novaReservaToolStripMenuItem, quadroDeReservasToolStripMenuItem, consultarReservasToolStripMenuItem });
            MenuReservas.Image = (System.Drawing.Image)resources.GetObject("MenuReservas.Image");
            MenuReservas.Name = "MenuReservas";
            MenuReservas.Size = new System.Drawing.Size(100, 24);
            MenuReservas.Text = "Reservas";
            // 
            // novaReservaToolStripMenuItem
            // 
            novaReservaToolStripMenuItem.Name = "novaReservaToolStripMenuItem";
            novaReservaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            novaReservaToolStripMenuItem.Text = "Nova Reserva";
            // 
            // quadroDeReservasToolStripMenuItem
            // 
            quadroDeReservasToolStripMenuItem.Name = "quadroDeReservasToolStripMenuItem";
            quadroDeReservasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            quadroDeReservasToolStripMenuItem.Text = "Quadro de Reservas";
            // 
            // consultarReservasToolStripMenuItem
            // 
            consultarReservasToolStripMenuItem.Name = "consultarReservasToolStripMenuItem";
            consultarReservasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            consultarReservasToolStripMenuItem.Text = "Consultar Reservas";
            // 
            // MenuChekInOut
            // 
            MenuChekInOut.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { novoServiçoToolStripMenuItem, checkOutToolStripMenuItem });
            MenuChekInOut.Image = (System.Drawing.Image)resources.GetObject("MenuChekInOut.Image");
            MenuChekInOut.Name = "MenuChekInOut";
            MenuChekInOut.Size = new System.Drawing.Size(128, 24);
            MenuChekInOut.Text = "Check In/Out";
            // 
            // novoServiçoToolStripMenuItem
            // 
            novoServiçoToolStripMenuItem.Name = "novoServiçoToolStripMenuItem";
            novoServiçoToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            novoServiçoToolStripMenuItem.Text = "Check In";
            // 
            // checkOutToolStripMenuItem
            // 
            checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            checkOutToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            checkOutToolStripMenuItem.Text = "Check Out";
            // 
            // MenuRelatorios
            // 
            MenuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { relátorio1ToolStripMenuItem });
            MenuRelatorios.Image = (System.Drawing.Image)resources.GetObject("MenuRelatorios.Image");
            MenuRelatorios.Name = "MenuRelatorios";
            MenuRelatorios.Size = new System.Drawing.Size(110, 24);
            MenuRelatorios.Text = "Relatórios";
            // 
            // relátorio1ToolStripMenuItem
            // 
            relátorio1ToolStripMenuItem.Name = "relátorio1ToolStripMenuItem";
            relátorio1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            relátorio1ToolStripMenuItem.Text = "Relátorio 1";
            relátorio1ToolStripMenuItem.Click += relátorio1ToolStripMenuItem_Click;
            // 
            // MenuSair
            // 
            MenuSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { logoutToolStripMenuItem });
            MenuSair.Image = (System.Drawing.Image)resources.GetObject("MenuSair.Image");
            MenuSair.Name = "MenuSair";
            MenuSair.Size = new System.Drawing.Size(68, 24);
            MenuSair.Text = "Sair";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += LogoutToolStripMenuItem_Click;
            // 
            // pnlTopo
            // 
            pnlTopo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlTopo.BackColor = System.Drawing.SystemColors.ControlLight;
            pnlTopo.Controls.Add(button7);
            pnlTopo.Controls.Add(button6);
            pnlTopo.Controls.Add(button5);
            pnlTopo.Controls.Add(button4);
            pnlTopo.Controls.Add(button3);
            pnlTopo.Controls.Add(button2);
            pnlTopo.Controls.Add(button1);
            pnlTopo.Location = new System.Drawing.Point(0, 42);
            pnlTopo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new System.Drawing.Size(869, 115);
            pnlTopo.TabIndex = 1;
            // 
            // button7
            // 
            button7.Cursor = System.Windows.Forms.Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button7.Image = (System.Drawing.Image)resources.GetObject("button7.Image");
            button7.Location = new System.Drawing.Point(763, 6);
            button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(93, 100);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Cursor = System.Windows.Forms.Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button6.Image = (System.Drawing.Image)resources.GetObject("button6.Image");
            button6.Location = new System.Drawing.Point(632, 6);
            button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(93, 100);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Cursor = System.Windows.Forms.Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button5.Image = (System.Drawing.Image)resources.GetObject("button5.Image");
            button5.Location = new System.Drawing.Point(500, 6);
            button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(93, 100);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Cursor = System.Windows.Forms.Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Image = (System.Drawing.Image)resources.GetObject("button4.Image");
            button4.Location = new System.Drawing.Point(376, 6);
            button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(93, 100);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = System.Windows.Forms.Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Image = (System.Drawing.Image)resources.GetObject("button3.Image");
            button3.Location = new System.Drawing.Point(252, 6);
            button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(93, 100);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Cursor = System.Windows.Forms.Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Image = (System.Drawing.Image)resources.GetObject("button2.Image");
            button2.Location = new System.Drawing.Point(129, 6);
            button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(93, 100);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Image = (System.Drawing.Image)resources.GetObject("button1.Image");
            button1.Location = new System.Drawing.Point(16, 6);
            button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(93, 100);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // pnlRight
            // 
            pnlRight.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            pnlRight.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            pnlRight.Controls.Add(label15);
            pnlRight.Controls.Add(label16);
            pnlRight.Controls.Add(label10);
            pnlRight.Controls.Add(label11);
            pnlRight.Controls.Add(label12);
            pnlRight.Controls.Add(pictureBox3);
            pnlRight.Controls.Add(label13);
            pnlRight.Controls.Add(label14);
            pnlRight.Controls.Add(label9);
            pnlRight.Controls.Add(lblUsuario);
            pnlRight.Controls.Add(label5);
            pnlRight.Controls.Add(pictureBox2);
            pnlRight.Controls.Add(lblCargo);
            pnlRight.Controls.Add(label7);
            pnlRight.Controls.Add(label4);
            pnlRight.Controls.Add(pictureBox1);
            pnlRight.Controls.Add(label3);
            pnlRight.Controls.Add(label2);
            pnlRight.Controls.Add(label1);
            pnlRight.Location = new System.Drawing.Point(864, 42);
            pnlRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new System.Drawing.Size(333, 762);
            pnlRight.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label15.Location = new System.Drawing.Point(224, 631);
            label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(20, 24);
            label15.TabIndex = 18;
            label15.Text = "5";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label16.Location = new System.Drawing.Point(25, 631);
            label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(174, 24);
            label16.TabIndex = 17;
            label16.Text = "Quartos Ocupados:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label10.Location = new System.Drawing.Point(23, 538);
            label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(93, 24);
            label10.TabIndex = 16;
            label10.Text = "Reservas:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label11.Location = new System.Drawing.Point(131, 538);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(20, 24);
            label11.TabIndex = 15;
            label11.Text = "5";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label12.Location = new System.Drawing.Point(-56, 651);
            label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(444, 26);
            label12.TabIndex = 14;
            label12.Text = "____________________________________";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(27, 446);
            pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(67, 77);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label13.Location = new System.Drawing.Point(223, 585);
            label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(30, 24);
            label13.TabIndex = 12;
            label13.Text = "10";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label14.Location = new System.Drawing.Point(24, 585);
            label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(182, 24);
            label14.TabIndex = 11;
            label14.Text = "Quartos Disponíveis:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label9.Location = new System.Drawing.Point(21, 300);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(67, 24);
            label9.TabIndex = 10;
            label9.Text = "Nome:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblUsuario.Location = new System.Drawing.Point(100, 300);
            lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new System.Drawing.Size(171, 24);
            lblUsuario.TabIndex = 9;
            lblUsuario.Text = "Hugo Vasconcelos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label5.Location = new System.Drawing.Point(-56, 374);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(444, 26);
            label5.TabIndex = 8;
            label5.Text = "____________________________________";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(25, 208);
            pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(67, 77);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblCargo.Location = new System.Drawing.Point(100, 346);
            lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new System.Drawing.Size(100, 24);
            lblCargo.TabIndex = 6;
            lblCargo.Text = "13/04/2019";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label7.Location = new System.Drawing.Point(23, 346);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(66, 24);
            label7.TabIndex = 5;
            label7.Text = "Cargo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label4.Location = new System.Drawing.Point(-69, 151);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(444, 26);
            label4.TabIndex = 4;
            label4.Text = "____________________________________";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(25, 29);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(67, 77);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label3.Location = new System.Drawing.Point(117, 122);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(120, 26);
            label3.TabIndex = 2;
            label3.Text = "07/05/2019";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(24, 123);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 26);
            label2.TabIndex = 1;
            label2.Text = "DATA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label1.Location = new System.Drawing.Point(97, 49);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(133, 36);
            label1.TabIndex = 0;
            label1.Text = "13:00:00";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.sem_foto;
            pictureBox4.Location = new System.Drawing.Point(180, 250);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(440, 323);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1197, 800);
            Controls.Add(pictureBox4);
            Controls.Add(pnlRight);
            Controls.Add(pnlTopo);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FrmMenu";
            Text = "Hotel Clodoaldo Animado";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += FrmMenu_Load;
            Resize += FrmMenu_Resize;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlTopo.ResumeLayout(false);
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóspedesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quartosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviçosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem novoProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentacoes;
        private System.Windows.Forms.ToolStripMenuItem novaVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoServiçoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entradasESaídasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuReservas;
        private System.Windows.Forms.ToolStripMenuItem novaReservaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quadroDeReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuChekInOut;
        private System.Windows.Forms.ToolStripMenuItem novoServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem cargoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relátorio1ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}