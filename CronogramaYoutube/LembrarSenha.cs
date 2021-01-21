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
            

            // recebendo o e-mail digitado pelo usuário
            string checar = txtBox_email.Text;

            // checar se foi digitado @ e .com no e-mail
            // veja que a var é do tipo boolean, resulta true ou false
            bool valor = checar.Contains("@") && checar.Contains(".com");

            // Se o valor for true (campo contem @ e .com, foi validado)
            if (valor == true)
            {
                MessageBox.Show("Foi enviado um link de recuperação de senha para o e-mail!");
            }

            else
            {
                MessageBox.Show("Por favor, digite um e-mail válido!");
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
