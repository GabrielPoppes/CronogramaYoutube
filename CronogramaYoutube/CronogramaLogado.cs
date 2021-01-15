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
            GerarColunas();
        }

        // MÉTODO PARA GERAR OS ITENS DAS COLUNAS
        private void GerarColunas()
        {
            // COLUNA DA LIST VIEW DO ID
            ListaID.Columns.Add("ID", 50).TextAlign = HorizontalAlignment.Center;
            // COLUNA DA LIST VIEW DO RESTANTE
            Lista.Columns.Add("DATA", 50).TextAlign = HorizontalAlignment.Center;
            Lista.Columns.Add("HORA", 50).TextAlign = HorizontalAlignment.Center;
            Lista.Columns.Add("TÍTULO DO VÍDEO", 230).TextAlign = HorizontalAlignment.Center;
            Lista.Columns.Add("GRAVADO [S/N]", 100).TextAlign = HorizontalAlignment.Center;
        }

        // Botão "CADASTRAR"
        private void button2_Click(object sender, EventArgs e)
        {
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

            int contadorID = ListaID.Items.Count + 1;
            string contadorIDString = contadorID.ToString();
            ListaID.Items.Add(new ListViewItem(contadorIDString));

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
