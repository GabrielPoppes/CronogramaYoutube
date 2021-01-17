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
    // pendencias
    // organizar os itens da list view por data
    public partial class CronogramaLogado : Form
    {
        public CronogramaLogado()
        {
            InitializeComponent();
            // Método para gerar as colunas assim que a tela é aberta
            GerarColunas();
        }

        // MÉTODO PARA GERAR OS ITENS DAS COLUNAS
        private void GerarColunas()
        {
            // ADIÇÃO DAS COLUNAS DO LIST VIEW, A ONDE TÁ AS ASPAS, É ONDE PODEMOS COLOCAR OS NOMES DAS COLUNAS...
            Lista.Columns.Add("ID", 50).TextAlign = HorizontalAlignment.Center;
            Lista.Columns.Add("", 80).TextAlign = HorizontalAlignment.Center;
            Lista.Columns.Add("", 60).TextAlign = HorizontalAlignment.Center;
            Lista.Columns.Add("", 200).TextAlign = HorizontalAlignment.Center;
            Lista.Columns.Add("", 100).TextAlign = HorizontalAlignment.Center;
            // Ativar o checkbox nas colunas
            Lista.CheckBoxes = true;
            // Permitir a multi seleção dos check boxs
            Lista.MultiSelect = true;
        }

        // Botão "CADASTRAR"
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataMasked.Text == "" || maskHora.Text == "" || tituloTxt.Text == "" || gravadoTxt.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
            }

            // método para adicionar items na List View
            MetodoAddItem();

        }

        // Método para adicionar os items na List view
        public void MetodoAddItem()
        {
            // Criando array
            string[] item = new string[5];

            if (dataMasked.Text != "" && maskHora.Text != "" && tituloTxt.Text != "" && gravadoTxt.Text != "")
            {
                // Lógica para implementar o contador da coluna "ID"
                // Veja que o contador é = Total de itens na coluna ID + 1
                // Na sequencia converto ele para string para ser implementado na coluna
                // E assim repete o looping
                int contadorID = Lista.Items.Count + 1;
                string contadorIDString = contadorID.ToString();

                // Add dados informados pelo user no array
                item[0] = contadorIDString;
                item[1] = dataMasked.Text;
                item[2] = maskHora.Text;
                item[3] = tituloTxt.Text;
                item[4] = gravadoTxt.Text;

                // Passando array para o List view
                Lista.Items.Add(new ListViewItem(item));

                // Limpar a List View
                dataMasked.Clear();
                maskHora.Clear();
                tituloTxt.Clear();
                gravadoTxt.Clear();
            }
        }

        // método para limpar lista selecionando o item
        public void btn_limparlista_Click(object sender, EventArgs e)
        {
            // Percorre toda a Listview (onde estão os itens e colunas)
            foreach(ListViewItem item in Lista.Items)
            {
                // Se um dos itens estiver checado
                if (item.Checked)
                {
                    // Remove o item checado, index == posição do item checado
                    Lista.Items.RemoveAt(item.Index);
                }

                // caso nenhum item seja selecionado, exibe alerta de erro para o usuário
                else
                {
                    MessageBox.Show("Selecione um item para ser removido!");
                }
            }
        }

        // Só é permitido que o usuário digite no máximo 3 caracteres no campo GRAVADO
        private void gravadoTxt_TextChanged(object sender, EventArgs e)
        {
            gravadoTxt.MaxLength = 3;
        }
    }
}
