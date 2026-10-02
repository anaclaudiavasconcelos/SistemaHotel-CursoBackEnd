using Microsoft.Reporting.WinForms;
using SistemaHotel.Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SistemaHotel.Relatorios
{
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            var tabela = new DataSet1();

           // new DataSet1TableAdapters.VendasTableAdapter().Fill(tabela.Vendas);

            reportViewer1 = new ReportViewer { Dock = DockStyle.Fill };

            var arquivoRelatorio = File.OpenRead(Path.GetFullPath(@"C:\Users\cesar\Desktop\SistemaHotel\SistemaHotel\SistemaHotel\Relatorios\rela.rdlc"));

            reportViewer1.LocalReport.LoadReportDefinition(arquivoRelatorio);

           // reportViewer1.LocalReport.DataSources
           //     .Add(new ReportDataSource("DataSet1", (System.Data.DataTable)tabela.Vendas));

            Controls.Clear();
            Controls.Add(reportViewer1);

            reportViewer1.RefreshReport();
        }
    }
}
