using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EscolaVirtual2322
{
    public partial class PedidosDados : Form
    {
        public PedidosDados()
        {
            InitializeComponent();
            PopularListV();
        }

        public void PopularListV()
        {
            lvPedidos.Items.Clear();
            for (int i = 0; i < Listas.dadosA.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Listas.dadosA[i].nome;
                item.SubItems.Add(Convert.ToString(Listas.dadosA[i].numAluno));
                item.SubItems.Add(Listas.dadosA[i].log);
                item.SubItems.Add(Listas.dadosA[i].pass);
                item.SubItems.Add(Convert.ToString(Listas.dadosA[i].nif));
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

        private void btnAceitarPedido_Click(object sender, EventArgs e)
        {
            var selectedItems = lvPedidos.SelectedItems
                .Cast<ListViewItem>()
                .ToList();
            
            foreach (var item in selectedItems)
            {
                var numAluno = item.SubItems[1].Text;
                var alunoDado = Listas.dadosA.FirstOrDefault(a => a.numAluno == numAluno);

                var aluno = Listas.anos
                    .SelectMany(p => p.turmas)
                    .SelectMany(t => t.listAlunos)
                    .FirstOrDefault(a => a.numAluno == numAluno);

                aluno.nome = alunoDado.nome;
                aluno.log = alunoDado.log;
                aluno.pass = alunoDado.pass;
                aluno.nif = alunoDado.nif;

                Listas.dadosA.Remove(alunoDado);
                lvPedidos.Items.Remove(item);
            }
        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {
            var selectedItems = lvPedidos.SelectedItems
                .Cast<ListViewItem>()
                .ToList();

            foreach (var item in selectedItems)
            {
                var numAluno = item.SubItems[1].Text;
                var aluno = Listas.dadosA.FirstOrDefault(a => a.numAluno == numAluno);
                Listas.dadosA.Remove(aluno);        
                lvPedidos.Items.Remove(item);         
            }
        }
    }
}
