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
        // Thread da Tela "CronogramaLogado"
        Thread Logado;
        // Thread da tela LembrarSenha
        Thread EsqueciSenha;

        public Form1()
        {
            InitializeComponent();
        }

        // Botão sair
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // criei o nomeusuario de modo público e sem valor (ele quem vai receber o valor do TxtBox com nome do user)
        public string nomeusuario = "";

        // Método para abrir a nova tela
        private void FormLogado()
        {
            Application.Run(new CronogramaLogado(this));
        }
        // Codificação do botão "ENTRAR", checa se os campos de login e senha estão preenchidos corretamente
        public void button1_Click(object sender, EventArgs e)
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

                // Atribuindo valor a variável "nomeusuariO" que recebe o nome do user digitado no TxtBox
                nomeusuario = btn_login.Text;
                // Instaciando a tela após logar, passando o valor "this" que se refere ao Form1, tela de login
                CronogramaLogado nome = new CronogramaLogado(this);

                // "this.Close() fecha a tela anterior, e mantém somente a nova aberta"
                this.Visible = false;
                // Abre a nova tela
                Logado.Start();


            }
        }

        private void btn_recuperarsenha_Click(object sender, EventArgs e)
        {
            EsqueciSenha = new Thread(ResgatarSenhar);
            EsqueciSenha.SetApartmentState(ApartmentState.MTA);
            this.Close();
            EsqueciSenha.Start();
        }

        public void ResgatarSenhar()
        {
            Application.Run(new LembrarSenha());
        }


    }
}
