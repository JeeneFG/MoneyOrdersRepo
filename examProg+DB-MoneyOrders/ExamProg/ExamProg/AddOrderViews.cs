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
    public partial class AddOrderViews : Form
    {
        public AddOrderViews()
        {
            InitializeComponent();
        }

        public OrderViewsInfo ordViewInf = new OrderViewsInfo();

        private void AddOrderViews_Load(object sender, EventArgs e)
        {
            orderViewsInfoBindingSource.DataSource = ordViewInf;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (orderViewNameTextBox.Text == "")
            {
                if (MessageBox.Show(this, "Ничего не введено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) return;
            }
            else
            {
                if (ordViewInf.OrderViewID > 0)
                {
                    ordViewInf.UpdateOrderView();
                }
                else
                {
                    ordViewInf.InsertNewOrderView();
                }
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
