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
                    var sql = "SELECT * FROM tb_Pessoas ";
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
            catch(Exception ex)
            {

            }
        }

        private void frmPessoas_Relatorio_Load(object sender, EventArgs e)
        {
            ListaPessaoas();
        }
    }
}
