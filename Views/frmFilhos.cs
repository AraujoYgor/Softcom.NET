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
    public partial class frmFilhos:Form
    {
        public frmFilhos()
        {
            InitializeComponent();
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void BuscarPais()
        {
            try
            {
                using(SqlConnection cn = new SqlConnection(Banco.IniciarConexao))
                {
                    cn.Open();
                    var sql = "SELECT Nome as 'Pais/Mãe' FROM tb_Pessoas WHERE Filho=1 ";
                    using(SqlDataAdapter da = new SqlDataAdapter(sql, cn))
                    {
                        using(DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dgvPaisComFilhos.DataSource = dt;

                        }
                    }
                }
            }
            finally
            {

            }
        }

        private void frmFilhos_Load(object sender, EventArgs e)
        {
            BuscarPais();
            dgvPaisComFilhos.Columns[0].Width = 180;
        }
    }
}
