using System;
using TrilhadeDesenvolvimento.NET.Model;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using TrilhadeDesenvolvimento.NET.Controler;
using Microsoft.VisualBasic;

namespace TrilhadeDesenvolvimento.NET.Views
{
    public partial class frmPessoas:Form
    {
        string origemCompleto = null;
        string foto = null;
        string pastaDestino = null;
        string destinoCompleto = null; 
        
        public frmPessoas()
        {
            InitializeComponent();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(destinoCompleto == null)
            {
                if(MessageBox.Show("Sem foto selecionada, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if(destinoCompleto != null)
            {
                File.Copy(origemCompleto, destinoCompleto, true);

                if(File.Exists(destinoCompleto))
                {
                    pbFoto.ImageLocation = destinoCompleto;
                    //MessageBox.Show(destinoCompleto);
                }
                else
                {
                    if(MessageBox.Show("Erro ao localizar a foto, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            try
            {
                using (SqlConnection cn = new SqlConnection(Banco.IniciarConexao))
                {
                    cn.Open();
                    var sql = "INSERT INTO tb_Pessoas (Nome, Sobrenome, Email, CPF, Sexo, Foto, Categoria, SalarioBase, Rua, Numero, Complemento, Bairro, Cidade, Estado, Filho, CEP) VALUES (@nome, @sobrenome, @email, @cpf, @sexo, @foto, @categoria, @salariobase, @rua, @numero, @complemento, @bairro, @cidade, @estado, @filho, @cep)";

                    using(SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@nome", tbNome.Text);
                        cmd.Parameters.AddWithValue("@sobrenome", tbSobrenome.Text);
                        cmd.Parameters.AddWithValue("@email", tbEmail.Text);
                        cmd.Parameters.AddWithValue("@cpf", tbCPF.Text);
                        cmd.Parameters.AddWithValue("@sexo", tbSexo.Text);
                        cmd.Parameters.AddWithValue("@foto", pbFoto.ImageLocation = destinoCompleto);
                        cmd.Parameters.AddWithValue("@categoria", tbCategoria.Text);
                        cmd.Parameters.AddWithValue("@salariobase", tbSalarioBase.Text);
                        cmd.Parameters.AddWithValue("@rua", tbRua.Text);
                        cmd.Parameters.AddWithValue("@numero", tbNumero.Text);
                        cmd.Parameters.AddWithValue("@complemento", tbPontodeReferencia.Text);
                        cmd.Parameters.AddWithValue("@bairro", tbBairro.Text);
                        cmd.Parameters.AddWithValue("@cidade", tbCidade.Text);
                        cmd.Parameters.AddWithValue("@estado", tbUF.Text);
                        cmd.Parameters.AddWithValue("@Filho", cbFilho.Checked);
                        cmd.Parameters.AddWithValue("@cep", tbCep.Text);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cadastro efetuado com sucesso!");

                    tbNome.Clear();
                    tbSobrenome.Clear();
                    tbEmail.Clear();
                    tbCPF.Clear();
                    tbSexo.SelectedItem = -1;
                    pbFoto.ImageLocation = null;
                    tbCategoria.SelectedItem = -1;
                    tbSalarioBase.Clear();
                    tbRua.Clear();
                    tbNumero.Clear();
                    tbPontodeReferencia.Clear();
                    tbBairro.Clear();
                    tbCidade.Clear();
                    tbUF.Clear();
                    cbFilho.Checked = false;
                    tbCep.Clear();

                }
               
            }catch(Exception ex)
            {
                MessageBox.Show("Dados não Inseridos\n\n" + ex.Message);
                
            }
        }
        private void btnFilhos_Click(object sender, EventArgs e)
        {
            frmFilhos filhos = new frmFilhos();
            filhos.ShowDialog();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbnSelecionaFoto_Click(object sender, EventArgs e)
        {
            origemCompleto = null;
            foto = null;
            pastaDestino = Model.Pessoas.caminhoFotos;
            destinoCompleto = null;

            if(ofdFoto.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = ofdFoto.FileName;
                foto = ofdFoto.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }

            if(File.Exists(destinoCompleto))
            {
                if(MessageBox.Show("O arquivo já existe, deseja substituir?", "Subistituir", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            pbFoto.ImageLocation = origemCompleto;
        }
        private void btnPesquisarCep_Click(object sender, EventArgs e)
        {
            string vCep = tbCep.Text;

            if(MessageBox.Show("Deseja pesquisar o CEP na internet?", "Buscar CEP", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(vCep != null)
                {
                    if(vCep.Length == 8)
                    {
                        if(Information.IsNumeric(vCep))
                        {
                            var vJson = Uteis.BuscarJsonCEP(vCep);
                            CEP.Unit Cep = new CEP.Unit();
                            Cep = CEP.DesSerializedClassUnit(vJson);
                            tbRua.Text = Cep.logradouro;
                            tbBairro.Text = Cep.bairro;
                            tbCidade.Text = Cep.localidade;
                            tbUF.Text = Cep.uf;
                            tbNumero.Focus();
                        }
                    }
                }
            }
        }
        private void cbFilho_CheckedChanged(object sender, EventArgs e)
        {
            CadastrarFilhos();
        }
        private void CadastrarFilhos()
        {
            if(cbFilho.Checked == false)
            {
                btnFilhos.Enabled = false;
            }
            else
            {
                btnFilhos.Enabled = true;
            }
        }


    }
}

