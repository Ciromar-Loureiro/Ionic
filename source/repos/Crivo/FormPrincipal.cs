using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Crivo.Code.DTO;

namespace Crivo
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void MenuIdentifica_Click(object sender, EventArgs e)
        {
            
        }

        private void palograficoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPalografico FormPalo = new FormPalografico();
            // Set the Parent Form of the Child window.

            FormPalo.ShowDialog();
        }
    }
}
