
namespace TrilhadeDesenvolvimento.NET.Views
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pESSOASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fILHOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATORIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bANCODEDADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROToolStripMenuItem,
            this.rELATORIOSToolStripMenuItem,
            this.bANCODEDADOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pESSOASToolStripMenuItem,
            this.fILHOSToolStripMenuItem});
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.cADASTROToolStripMenuItem.Text = "CADASTRO";
            // 
            // pESSOASToolStripMenuItem
            // 
            this.pESSOASToolStripMenuItem.Name = "pESSOASToolStripMenuItem";
            this.pESSOASToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pESSOASToolStripMenuItem.Text = "PESSOAS";
            this.pESSOASToolStripMenuItem.Click += new System.EventHandler(this.pESSOASToolStripMenuItem_Click);
            // 
            // fILHOSToolStripMenuItem
            // 
            this.fILHOSToolStripMenuItem.Name = "fILHOSToolStripMenuItem";
            this.fILHOSToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.fILHOSToolStripMenuItem.Text = "FILHOS";
            this.fILHOSToolStripMenuItem.Click += new System.EventHandler(this.fILHOSToolStripMenuItem_Click);
            // 
            // rELATORIOSToolStripMenuItem
            // 
            this.rELATORIOSToolStripMenuItem.Name = "rELATORIOSToolStripMenuItem";
            this.rELATORIOSToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.rELATORIOSToolStripMenuItem.Text = "RELATORIOS";
            this.rELATORIOSToolStripMenuItem.Click += new System.EventHandler(this.rELATORIOSToolStripMenuItem_Click);
            // 
            // bANCODEDADOSToolStripMenuItem
            // 
            this.bANCODEDADOSToolStripMenuItem.Name = "bANCODEDADOSToolStripMenuItem";
            this.bANCODEDADOSToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.bANCODEDADOSToolStripMenuItem.Text = "BANCO DE DADOS";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rELATORIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bANCODEDADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pESSOASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fILHOSToolStripMenuItem;
    }
}

