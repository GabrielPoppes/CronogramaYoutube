using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CronogramaYoutube
{
    public partial class LembrarSenha : Form
    {
        Thread telalogin;
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

        private void button2_Click(object sender, EventArgs e)
        {
            telalogin = new Thread(AbrirLogin);
            telalogin.SetApartmentState(ApartmentState.MTA);
            this.Close();
            telalogin.Start();
        }

        private void AbrirLogin()
        {
            Application.Run(new Form1());
        }
    }
}
