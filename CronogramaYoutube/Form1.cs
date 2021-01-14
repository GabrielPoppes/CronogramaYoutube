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
    public partial class Form1 : Form
    {
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

            
        }
    }
}
