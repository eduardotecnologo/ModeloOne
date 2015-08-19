using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Systemgestão
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Configurando a Hora e a Data
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
            //Fim Configurando a Hora e a Data
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadClientes frmc = new frmCadClientes();
            frmc.Show();
        }

        private void softwaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadSoftware frmp = new frmCadSoftware();
            frmp.Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFuncionarios frmf = new frmCadFuncionarios();
            frmf.Show();
        }

        private void desenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadDesenvolvedores frmd = new frmCadDesenvolvedores();
            frmd.Show();

        }
    }
}
