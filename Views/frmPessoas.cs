using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using TrilhadeDesenvolvimento.NET.Controler;

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
                    //pbFoto.ImageLocation
                    tbCategoria.SelectedItem = -1;
                    tbSalarioBase.Clear();
                    tbRua.Clear();
                    tbNumero.Clear();
                    tbPontodeReferencia.Clear();
                    tbBairro.Clear();
                    tbCidade.Clear();
                    tbUF.Clear();
                    //cbFilho.
                    tbCep.Clear();

                }
               
            }catch(Exception ex)
            {
                MessageBox.Show("Dados não Inseridos\n\n" + ex.Message);
                
            }
        }
    }
}

