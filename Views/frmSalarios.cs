using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrilhadeDesenvolvimento.NET.Controler;

namespace TrilhadeDesenvolvimento.NET.Views
{
    public partial class frmSalarios:Form
    {
        double salarioFinal = 0.00;
        double salariob = 0.00;
        int dias = 0;
        int qtd = 0; 

        public frmSalarios()
        {
            InitializeComponent();
        }

        private void frmSalarios_Load(object sender, EventArgs e)
        {
            BuscarPessoas();
            dgvPessoas.Columns[0].Width = 100;
            dgvPessoas.Columns[1].Width = 100;
            dgvPessoas.Columns[2].Width = 70;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            switch(tbCategoria.Text)
            {
                case "ADVOGADO":

                tbDias.Enabled = false;
                tbPercentual.Enabled = false;
                SalarioAdvogado(tbSalarioB.Text, tbQtd.Text);

                break;

                case "COZINHEIRO":

                tbDias.Enabled = false;
                tbPercentual.Enabled = false;
                SalarioCozinheiro(tbSalarioB.Text, tbQtd.Text);

                break;
                case "VENDEDOR":
                tbDias.Enabled = true;
                tbPercentual.Enabled = true;
                SalarioVendedor(tbSalarioB.Text, tbQtd.Text);
                break;
            }
        }

        private void SalarioAdvogado(string salarioBase, string processos)
        {
            salariob = double.Parse(salarioBase);
            qtd = int.Parse(processos);

            salarioFinal = salariob * qtd;
        }
        private void SalarioCozinheiro(string salarioBase, string Horas)
        {
            salariob = double.Parse(salarioBase);
            qtd = int.Parse(Horas);

            salarioFinal = salariob * qtd;
        }
        private void SalarioVendedor(string salarioBase, string Dias)
        {
            salariob = double.Parse(salarioBase);
            qtd = int.Parse(Dias);

            double percentual = (5 / 100) * salariob;

            salarioFinal = (salariob * 8) + percentual;
        }

        private void BuscarPessoas()
        {
            try
            {
                using(SqlConnection cn = new SqlConnection(Banco.IniciarConexao))
                {
                    cn.Open();
                    var sql = "SELECT  Nome AS 'NOME', Categoria AS CATEGORIA, SalarioBase AS 'SALARIO'FROM tb_Pessoas ";
                    using(SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                    {
                        using(DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvPessoas.DataSource = dt;

                        }
                    }
                }
            }
            finally
            {

            }
        }
    }
}
