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
    public partial class CronogramaLogado : Form
    {
        public CronogramaLogado()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dataTxt.Text) || string.IsNullOrEmpty(horaTxt.Text) || string.IsNullOrEmpty(tituloTxt.Text) || string.IsNullOrEmpty(gravadoTxt.Text))
                return;
            ListViewItem item = new ListViewItem(dataTxt.Text);
            item.SubItems.Add(dataTxt.Text);
            Lista.Items.Add(item);
            dataTxt.Clear();
            horaTxt.Clear();
            tituloTxt.Clear();
            gravadoTxt.Clear();
            dataTxt.Focus();
                
            
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
