﻿
namespace Crivo
{
    partial class FormTabelas
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Tab 85 - Produtividade - Sudeste - Amostra Total",
            "Tab 86 - Produtividade - Sudeste - Sexo Feminino",
            "Tab 87 - Produtividade - Sudeste - Sexo Masculino",
            "Tab 88 - Produtividade - Sudeste - Ens. Fundamental",
            "Tab 89 - Produtividade - Sudeste - Ens. Médio",
            "Tab 90 - Produtividade - Sudeste - Ens. Superior",
            "Tab 91 - NOR - Sudeste - Ens. Fundamental",
            "Tab 91 - NOR - Sudeste - Ens. Médio",
            "Tab 91 - NOR - Sudeste - Ens. Superior",
            "Tab 91 - NOR - Sudeste - Amostra Total",
            "Tab 92 - NOR - Sudeste - Sexo Feminino",
            "Tab 92 - NOR - Sudeste - Sexo Masculino",
            ""});
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(483, 214);
            this.listBox1.TabIndex = 0;
            // 
            // FormTabelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Name = "FormTabelas";
            this.Text = "Selecione a Tabela Correspondente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}