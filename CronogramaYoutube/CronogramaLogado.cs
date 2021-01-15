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
    // pendencias:
    // 1. adicionar id de item por item para saber quantos tem
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
            // COLUNA DA LIST VIEW DO ID
            ListaID.Columns.Add("", 50).TextAlign = HorizontalAlignment.Center;
            // COLUNA DA LIST VIEW DO RESTANTE
            Lista.Columns.Add("", 60).TextAlign = HorizontalAlignment.Center;
            Lista.Columns.Add("", 60).TextAlign = HorizontalAlignment.Center;
            Lista.Columns.Add("", 200).TextAlign = HorizontalAlignment.Center;
            Lista.Columns.Add("", 100).TextAlign = HorizontalAlignment.Center;
        }

        // Botão "CADASTRAR"
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataTxt.Text == "" || horaTxt.Text == "" || tituloTxt.Text == "" || gravadoTxt.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
            }

            // método para adicionar items na List View
            MetodoAddItem();

        }

        private void RemoverItemsListView()
        {
            
        }

        // Método para adicionar os items na List view
        private void MetodoAddItem()
        {
            // Criando array
            string[] item = new string[4];

            if (dataTxt.Text != "" && horaTxt.Text != "" && tituloTxt.Text != "" && gravadoTxt.Text != "")
            {
                // Lógica para implementar o contador da coluna "ID"
                // Veja que o contador é = Total de itens na coluna ID + 1
                // Na sequencia converto ele para string para ser implementado na coluna
                // E assim repete o looping
                int contadorID = ListaID.Items.Count + 1;
                string contadorIDString = contadorID.ToString();
                ListaID.Items.Add(new ListViewItem(contadorIDString));

                // Add dados informados pelo user no array
                item[0] = dataTxt.Text;
                item[1] = horaTxt.Text;
                item[2] = tituloTxt.Text;
                item[3] = gravadoTxt.Text;

                // Passando array para o List view
                Lista.Items.Add(new ListViewItem(item));

                // Limpar a List View
                dataTxt.Clear();
                horaTxt.Clear();
                tituloTxt.Clear();
                gravadoTxt.Clear();
            }
        }

        private void btn_limparlista_Click(object sender, EventArgs e)
        {
            if (Lista.Items.Count > 0)
            {
                Lista.Items.Remove(Lista.SelectedItems[0]);
            }
        }

    }
}
