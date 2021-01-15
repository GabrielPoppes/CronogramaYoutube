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
    public partial class Form1 : Form
    {
        // Thred da Tela "CronogramaLogado"
        Thread Logado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Botão sair
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Codificação do botão "ENTRAR", checa se os campos de login e senha estão preenchidos corretamente
        private void button1_Click(object sender, EventArgs e)
        {
            if (btn_login.Text == "" && btn_senha.Text == "")
            {
                MessageBox.Show("Por favor, insira os dados necessários para acessar o sistema!");
            }

            else if (btn_login.Text == "")
            {
                MessageBox.Show("Por favor, digite o usuário!");
            }

            else if (btn_senha.Text == "")
            {
                MessageBox.Show("Por favor, digite a senha!");
            }

            else
            {
                // Codificação para abrir nova tela
                Logado = new Thread(FormLogado);
                Logado.SetApartmentState(ApartmentState.STA);
                // "this.Close() fecha a tela anterior, e mantém somente a nova aberta"
                this.Close();
                // Abre a nova tela
                Logado.Start();

                
            }

            
        }
        // Método para abrir a nova tela
        private void FormLogado()
        {
            Application.Run(new CronogramaLogado());
        }

    }
}
