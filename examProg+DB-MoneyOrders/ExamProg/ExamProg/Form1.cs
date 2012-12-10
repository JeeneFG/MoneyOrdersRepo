using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExamProg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form2 gg = new Form2();
            gg.MdiParent = this;
            foreach (Form ff in Application.OpenForms)
            {
                Type t = ff.GetType();
                if (t.Name=="Form2")
                {
                    MessageBox.Show(this, "Уже открыто", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
                }
            }
            gg.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form3 ff = new Form3();
            ff.MdiParent=this;
            ff.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form4 tt=new Form4();
            tt.MdiParent = this;
            tt.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 kk = new Form5();
            kk.MdiParent = this;
            kk.Show();
        }
    }
}
