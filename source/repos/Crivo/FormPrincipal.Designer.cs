
namespace Crivo
{
    partial class FormPrincipal
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
            if (disposing && (components != null))
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.identificaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atençãoConcentradaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atençãoDifusaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inteligênicaGeralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palograficoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lbIdade = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbSexo = new System.Windows.Forms.Label();
            this.txtEscola = new System.Windows.Forms.TextBox();
            this.lbEscola = new System.Windows.Forms.Label();
            this.menuPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identificaçãoToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(838, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // identificaçãoToolStripMenuItem
            // 
            this.identificaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atençãoConcentradaToolStripMenuItem1,
            this.atençãoDifusaToolStripMenuItem1,
            this.inteligênicaGeralToolStripMenuItem,
            this.palograficoToolStripMenuItem1});
            this.identificaçãoToolStripMenuItem.Name = "identificaçãoToolStripMenuItem";
            this.identificaçãoToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.identificaçãoToolStripMenuItem.Text = "Inserir Testes";
            // 
            // atençãoConcentradaToolStripMenuItem1
            // 
            this.atençãoConcentradaToolStripMenuItem1.Name = "atençãoConcentradaToolStripMenuItem1";
            this.atençãoConcentradaToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.atençãoConcentradaToolStripMenuItem1.Text = "Atenção Concentrada";
            // 
            // atençãoDifusaToolStripMenuItem1
            // 
            this.atençãoDifusaToolStripMenuItem1.Name = "atençãoDifusaToolStripMenuItem1";
            this.atençãoDifusaToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.atençãoDifusaToolStripMenuItem1.Text = "Atenção Difusa";
            // 
            // inteligênicaGeralToolStripMenuItem
            // 
            this.inteligênicaGeralToolStripMenuItem.Name = "inteligênicaGeralToolStripMenuItem";
            this.inteligênicaGeralToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.inteligênicaGeralToolStripMenuItem.Text = "Inteligênica Geral";
            // 
            // palograficoToolStripMenuItem1
            // 
            this.palograficoToolStripMenuItem1.Name = "palograficoToolStripMenuItem1";
            this.palograficoToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.palograficoToolStripMenuItem1.Text = "Palográfico";
            this.palograficoToolStripMenuItem1.Click += new System.EventHandler(this.palograficoToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbEscola);
            this.panel1.Controls.Add(this.lbSexo);
            this.panel1.Controls.Add(this.lbIdade);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Controls.Add(this.txtEscola);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.txtIdade);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 293);
            this.panel1.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 27);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(296, 23);
            this.txtNome.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(7, 9);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(40, 15);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(7, 73);
            this.txtIdade.Multiline = true;
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(40, 23);
            this.txtIdade.TabIndex = 0;
            // 
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Location = new System.Drawing.Point(7, 55);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(36, 15);
            this.lbIdade.TabIndex = 1;
            this.lbIdade.Text = "Idade";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(40, 23);
            this.textBox1.TabIndex = 0;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(53, 55);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(32, 15);
            this.lbSexo.TabIndex = 1;
            this.lbSexo.Text = "Sexo";
            // 
            // txtEscola
            // 
            this.txtEscola.Location = new System.Drawing.Point(99, 73);
            this.txtEscola.Multiline = true;
            this.txtEscola.Name = "txtEscola";
            this.txtEscola.Size = new System.Drawing.Size(204, 23);
            this.txtEscola.TabIndex = 0;
            // 
            // lbEscola
            // 
            this.lbEscola.AutoSize = true;
            this.lbEscola.Location = new System.Drawing.Point(99, 55);
            this.lbEscola.Name = "lbEscola";
            this.lbEscola.Size = new System.Drawing.Size(73, 15);
            this.lbEscola.TabIndex = 1;
            this.lbEscola.Text = "Escolaridade";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FormPrincipal";
            this.Text = "Crivo - Designed byCi";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem identificaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atençãoConcentradaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atençãoDifusaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inteligênicaGeralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palograficoToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEscola;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbIdade;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtEscola;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtNome;
    }
}