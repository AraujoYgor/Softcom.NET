using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrilhadeDesenvolvimento.NET.Views
{
    public partial class frmPrincipal:Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pESSOASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPessoas frmPessoas = new frmPessoas();
            frmPessoas.ShowDialog();
        }

        private void fILHOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastrodeFilhos Filhos = new frmCadastrodeFilhos();
            Filhos.ShowDialog();
        }

        private void rELATORIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPessoas_Relatorio pessoas_Relatorio = new frmPessoas_Relatorio();
            pessoas_Relatorio.ShowDialog();
        }
    }
}
