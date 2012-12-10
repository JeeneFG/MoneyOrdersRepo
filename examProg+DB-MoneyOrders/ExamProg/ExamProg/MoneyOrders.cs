using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ExamProgLibrary;

namespace ExamProg
{
    public partial class MoneyOrders : Form
    {
        public MoneyOrders()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            OrderViews gg = new OrderViews();
            gg.MdiParent = this;
            foreach (Form ff in Application.OpenForms)
            {
                Type t = ff.GetType();
                if (t.Name == "OrderViews")
                {
                    MessageBox.Show(this, "Уже открыто", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
            gg.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Senders ff = new Senders();
            ff.MdiParent=this;
            foreach (Form hh in Application.OpenForms)
            {
                Type l = hh.GetType();
                if (l.Name == "Senders")
                {
                    MessageBox.Show(this, "Уже открыто", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
            ff.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Recipients tt=new Recipients();
            tt.MdiParent = this;
            foreach (Form ff in Application.OpenForms)
            {
                Type t = ff.GetType();
                if (t.Name == "Recipients")
                {
                    MessageBox.Show(this, "Уже открыто", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
            tt.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Orders kk = new Orders();
            kk.Text = "Orders";
            kk.MdiParent = this;
            foreach (Form ff in Application.OpenForms)
            {
                Type t = ff.GetType();
                if (t.Name == "Orders")
                {
                    MessageBox.Show(this, "Уже открыто", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
            kk.Show();
        }

        private void закрытьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i > 0; i--)
            {
                Application.OpenForms[i].Close();
            }      
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
