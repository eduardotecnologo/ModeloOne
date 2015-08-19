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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Chamando o Formulário Principal
            if ((textBox1.Text == "ctksoluc") && (textBox2.Text == "12345"))
            {
                frmPrincipal frmp = new frmPrincipal();
                frmp.Show();
                frmp.Visible = true;
            }
            else //Se não Mostrar mensagem
            {
                MessageBox.Show("Usuário ou Senha inválidos", "Ocorreu um erro ao Autenticar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
