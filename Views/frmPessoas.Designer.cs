
namespace TrilhadeDesenvolvimento.NET.Views
{
    partial class frmPessoas
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPessoas));
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbSobrenome = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbCPF = new System.Windows.Forms.TextBox();
            this.tbCategoria = new System.Windows.Forms.ComboBox();
            this.tbSexo = new System.Windows.Forms.ComboBox();
            this.tbSalarioBase = new System.Windows.Forms.TextBox();
            this.tbRua = new System.Windows.Forms.TextBox();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbUF = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.cbFilho = new System.Windows.Forms.CheckBox();
            this.tbPontodeReferencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.tbnSelecionaFoto = new System.Windows.Forms.Button();
            this.btnLimparFoto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbCep = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.btnPesquisarCep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(26, 44);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.Size = new System.Drawing.Size(86, 22);
            this.tbCodigo.TabIndex = 0;
            this.tbCodigo.TabStop = false;
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(118, 44);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(180, 22);
            this.tbNome.TabIndex = 1;
            // 
            // tbSobrenome
            // 
            this.tbSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSobrenome.Location = new System.Drawing.Point(26, 122);
            this.tbSobrenome.Name = "tbSobrenome";
            this.tbSobrenome.Size = new System.Drawing.Size(272, 22);
            this.tbSobrenome.TabIndex = 2;
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(26, 204);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(272, 22);
            this.tbEmail.TabIndex = 3;
            // 
            // tbCPF
            // 
            this.tbCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCPF.Location = new System.Drawing.Point(26, 294);
            this.tbCPF.Name = "tbCPF";
            this.tbCPF.Size = new System.Drawing.Size(144, 22);
            this.tbCPF.TabIndex = 4;
            // 
            // tbCategoria
            // 
            this.tbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCategoria.FormattingEnabled = true;
            this.tbCategoria.Items.AddRange(new object[] {
            "ADVOGADO",
            "COZINHEIRO",
            "VENDEDOR"});
            this.tbCategoria.Location = new System.Drawing.Point(26, 376);
            this.tbCategoria.Name = "tbCategoria";
            this.tbCategoria.Size = new System.Drawing.Size(144, 24);
            this.tbCategoria.TabIndex = 5;
            // 
            // tbSexo
            // 
            this.tbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSexo.FormattingEnabled = true;
            this.tbSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMININO"});
            this.tbSexo.Location = new System.Drawing.Point(176, 376);
            this.tbSexo.Name = "tbSexo";
            this.tbSexo.Size = new System.Drawing.Size(122, 24);
            this.tbSexo.TabIndex = 6;
            // 
            // tbSalarioBase
            // 
            this.tbSalarioBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSalarioBase.Location = new System.Drawing.Point(176, 294);
            this.tbSalarioBase.Name = "tbSalarioBase";
            this.tbSalarioBase.Size = new System.Drawing.Size(122, 22);
            this.tbSalarioBase.TabIndex = 7;
            // 
            // tbRua
            // 
            this.tbRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRua.Location = new System.Drawing.Point(325, 122);
            this.tbRua.Name = "tbRua";
            this.tbRua.Size = new System.Drawing.Size(272, 22);
            this.tbRua.TabIndex = 9;
            // 
            // tbNumero
            // 
            this.tbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumero.Location = new System.Drawing.Point(326, 204);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.Size = new System.Drawing.Size(50, 22);
            this.tbNumero.TabIndex = 10;
            // 
            // tbBairro
            // 
            this.tbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBairro.Location = new System.Drawing.Point(325, 294);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(216, 22);
            this.tbBairro.TabIndex = 12;
            // 
            // tbUF
            // 
            this.tbUF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUF.Location = new System.Drawing.Point(547, 294);
            this.tbUF.Name = "tbUF";
            this.tbUF.Size = new System.Drawing.Size(50, 22);
            this.tbUF.TabIndex = 13;
            // 
            // tbCidade
            // 
            this.tbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCidade.Location = new System.Drawing.Point(325, 378);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(196, 22);
            this.tbCidade.TabIndex = 14;
            // 
            // cbFilho
            // 
            this.cbFilho.AutoSize = true;
            this.cbFilho.Location = new System.Drawing.Point(527, 378);
            this.cbFilho.Name = "cbFilho";
            this.cbFilho.Size = new System.Drawing.Size(70, 24);
            this.cbFilho.TabIndex = 15;
            this.cbFilho.Text = "Filhos";
            this.cbFilho.UseVisualStyleBackColor = true;
            // 
            // tbPontodeReferencia
            // 
            this.tbPontodeReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPontodeReferencia.Location = new System.Drawing.Point(382, 204);
            this.tbPontodeReferencia.Name = "tbPontodeReferencia";
            this.tbPontodeReferencia.Size = new System.Drawing.Size(215, 22);
            this.tbPontodeReferencia.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Sobrenome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "CPF:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Caterogia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Sexo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Salario Base:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Rua:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(333, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Nº";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(382, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Ponto de Referencia:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(333, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 20);
            this.label12.TabIndex = 26;
            this.label12.Text = "Bairro:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(547, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "UF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(333, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Cidade:";
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(627, 44);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(197, 276);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 29;
            this.pbFoto.TabStop = false;
            // 
            // tbnSelecionaFoto
            // 
            this.tbnSelecionaFoto.Location = new System.Drawing.Point(647, 336);
            this.tbnSelecionaFoto.Name = "tbnSelecionaFoto";
            this.tbnSelecionaFoto.Size = new System.Drawing.Size(143, 27);
            this.tbnSelecionaFoto.TabIndex = 16;
            this.tbnSelecionaFoto.Text = "Selecionar Foto";
            this.tbnSelecionaFoto.UseVisualStyleBackColor = true;
            this.tbnSelecionaFoto.Click += new System.EventHandler(this.tbnSelecionaFoto_Click);
            // 
            // btnLimparFoto
            // 
            this.btnLimparFoto.Location = new System.Drawing.Point(647, 376);
            this.btnLimparFoto.Name = "btnLimparFoto";
            this.btnLimparFoto.Size = new System.Drawing.Size(143, 26);
            this.btnLimparFoto.TabIndex = 31;
            this.btnLimparFoto.TabStop = false;
            this.btnLimparFoto.Text = "Limpar Foto";
            this.btnLimparFoto.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 63);
            this.panel1.TabIndex = 32;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(393, 10);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(159, 41);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbCep
            // 
            this.tbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCep.Location = new System.Drawing.Point(325, 44);
            this.tbCep.Name = "tbCep";
            this.tbCep.Size = new System.Drawing.Size(124, 22);
            this.tbCep.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(333, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "CEP:";
            // 
            // ofdFoto
            // 
            this.ofdFoto.Filter = "JPG|*.jpg|400x400pixels|*.*|PNG|*.png|400x400pixels|*.*";
            // 
            // btnPesquisarCep
            // 
            this.btnPesquisarCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCep.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnPesquisarCep.Location = new System.Drawing.Point(455, 42);
            this.btnPesquisarCep.Name = "btnPesquisarCep";
            this.btnPesquisarCep.Size = new System.Drawing.Size(142, 23);
            this.btnPesquisarCep.TabIndex = 35;
            this.btnPesquisarCep.Text = "Pesquisar Cep";
            this.btnPesquisarCep.UseVisualStyleBackColor = true;
            this.btnPesquisarCep.Click += new System.EventHandler(this.btnPesquisarCep_Click);
            // 
            // frmPessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(847, 487);
            this.Controls.Add(this.btnPesquisarCep);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbCep);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimparFoto);
            this.Controls.Add(this.tbnSelecionaFoto);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPontodeReferencia);
            this.Controls.Add(this.cbFilho);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbUF);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.tbRua);
            this.Controls.Add(this.tbSalarioBase);
            this.Controls.Add(this.tbSexo);
            this.Controls.Add(this.tbCategoria);
            this.Controls.Add(this.tbCPF);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbSobrenome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.tbCodigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoas";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tbNome;
        public System.Windows.Forms.TextBox tbSobrenome;
        public System.Windows.Forms.TextBox tbEmail;
        public System.Windows.Forms.TextBox tbCPF;
        public System.Windows.Forms.ComboBox tbCategoria;
        public System.Windows.Forms.ComboBox tbSexo;
        public System.Windows.Forms.TextBox tbSalarioBase;
        public System.Windows.Forms.TextBox tbRua;
        public System.Windows.Forms.TextBox tbNumero;
        public System.Windows.Forms.TextBox tbBairro;
        public System.Windows.Forms.TextBox tbUF;
        public System.Windows.Forms.TextBox tbCidade;
        public System.Windows.Forms.CheckBox cbFilho;
        public System.Windows.Forms.TextBox tbPontodeReferencia;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button tbnSelecionaFoto;
        private System.Windows.Forms.Button btnLimparFoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tbCep;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
        private System.Windows.Forms.Button btnPesquisarCep;
    }
}