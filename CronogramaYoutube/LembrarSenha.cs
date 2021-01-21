using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CronogramaYoutube
{
    public partial class LembrarSenha : Form
    {
        public LembrarSenha()
        {
            InitializeComponent();
        }

        private void btn_recuperarsenha_Click(object sender, EventArgs e)
        {
            if (txtBox_email.Text == "")
            {
                MessageBox.Show("Por favor, digite seu e-mail!");
            }

            else
            {
                MessageBox.Show("Foi enviado um link de recuperação de senha para o e-mail!");
            }
        }
    }
}
