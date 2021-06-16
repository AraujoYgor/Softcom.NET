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
    public partial class frmPessoas_Relatorio:Form
    {
        public frmPessoas_Relatorio()
        {
            InitializeComponent();
        }

        private void ListaPessaoas()
        {
            try
            {
                using(SqlConnection cn = new SqlConnection(Banco.IniciarConexao))
                {
                    cn.Open();
                    var sql = "SELECT Codigo, Nome, Sobrenome, Email, CPF, Sexo, Categoria, SalarioBase as 'Salario Base', CEP, Filho FROM tb_Pessoas ";
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

        private void frmPessoas_Relatorio_Load(object sender, EventArgs e)
        {
            ListaPessaoas();
            dgvPessoas.Columns[0].Width = 80;
            dgvPessoas.Columns[1].Width = 150;
            dgvPessoas.Columns[2].Width = 200;
            dgvPessoas.Columns[3].Width = 200;
            dgvPessoas.Columns[4].Width = 200;
            dgvPessoas.Columns[6].Width = 150;
            dgvPessoas.Columns[6].Width = 150;
            dgvPessoas.Columns[7].Width = 150;
            dgvPessoas.Columns[8].Width = 150;
            dgvPessoas.Columns[9].Width = 150;
            
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection cn = new SqlConnection(Banco.IniciarConexao))
                {
                    bool filho = false;
                    cn.Open();
                    var sql = "SELECT Codigo, Nome, Sobrenome, Email, CPF, Sexo, Categoria, SalarioBase, CEP, Filho FROM tb_Pessoas ";

                        switch(cbxPesquisa.Text)
                    {
                        case "NOME":
                            sql += "WHERE Nome like '%" + tbBuscado.Text + "%' ";
                        break;

                        case "SOBRENOME":
                            sql += "WHERE Sobrenome like '%" + tbBuscado.Text + "%' ";
                        break;

                        case "CPF":
                            sql += "WHERE CPF like '%" + tbBuscado.Text + "%' ";
                        break;


                    }
                    if(cbxFilhos.Text == "SIM")
                    {
                        filho = true;
                        sql += "and Filho = 1";

                    }
                    else
                    {
                        filho = false;
                        sql += "and Filho = 0";
                    }
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
            catch (Exception ex)
            {
                MessageBox.Show("Impossivel consultar sem dados" + ex.Message);
            }
        }

        private void btnLimparFiltros_Click(object sender, EventArgs e)
        {
            cbxPesquisa.SelectedIndex = -1;
            cbxFilhos.SelectedIndex = -1;
            tbBuscado.Text = "";
            rbFiltrosAvancados.Checked = false;
            
            ListaPessaoas();
        }

        private void rbFiltrosAvancados_CheckedChanged(object sender, EventArgs e)
        {
            cbxCategoria.Enabled = true;
            cbxSexo.Enabled = true;
            cbxFilhos.Enabled = true;
        }
    }
}
