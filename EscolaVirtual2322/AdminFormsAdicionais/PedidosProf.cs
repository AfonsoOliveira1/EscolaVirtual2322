using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual2322.AdminFormsAdicionais
{
    public partial class PedidosProf : Form
    {
        public PedidosProf()
        {
            InitializeComponent();
            PopularListV();
        }
        public void PopularListV()
        {
            lvPedidos.Items.Clear();
            for (int i = 0; i < Listas.dadosP.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Listas.dadosP[i].nome;
                item.SubItems.Add(Convert.ToString(Listas.dadosP[i].id));
                item.SubItems.Add(Listas.dadosP[i].log);
                item.SubItems.Add(Listas.dadosP[i].pass);
                item.SubItems.Add(Convert.ToString(Listas.dadosP[i].nif));
                lvPedidos.Items.Add(item);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Application.OpenForms["AdminForm"].Show();
            this.Close();
        }

        private void lvPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPedidos.SelectedItems.Count > 0)
            {
                btnAceitarPedido.Enabled = true;
                btnEliminarPedido.Enabled = true;
            }
            else
            {
                btnAceitarPedido.Enabled = false;
                btnEliminarPedido.Enabled = false;
            }
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            var selectedItems = lvPedidos.SelectedItems
                .Cast<ListViewItem>()
                .ToList();

            foreach (var item in selectedItems)
            {
                var idProf = Convert.ToInt32(item.SubItems[1].Text);
                var profDado = Listas.dadosP.FirstOrDefault(a => a.id == idProf);
                Listas.dadosP.Remove(profDado);
                lvPedidos.Items.Remove(item);
            }
        }

        private void btnAceitarPedido_Click(object sender, EventArgs e)
        {
            var selectedItems = lvPedidos.SelectedItems
                .Cast<ListViewItem>()
                .ToList();

            foreach (var item in selectedItems)
            {
                var idProf = Convert.ToInt32(item.SubItems[1].Text);
                var profDado = Listas.dadosP.FirstOrDefault(a => a.id == idProf);

                var prof = Listas.anos
                    .SelectMany(a => a.turmas)
                    .SelectMany(t => t.listDisciplinas)
                    .SelectMany(p => p.profs)
                    .FirstOrDefault(a => a.id == idProf);

                prof.nome = profDado.nome;
                prof.log = profDado.log;
                prof.pass = profDado.pass;
                prof.nif = profDado.nif;

                Listas.dadosP.Remove(profDado);
                lvPedidos.Items.Remove(item);
            }
        }
    }
}
