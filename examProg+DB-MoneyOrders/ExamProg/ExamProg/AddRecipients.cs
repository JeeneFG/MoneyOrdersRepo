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
    public partial class AddRecipients : Form
    {
        public AddRecipients()
        {
            InitializeComponent();
        }

        public RecipientsInfo recInfo = new RecipientsInfo();

        private void AddRecipients_Load(object sender, EventArgs e)
        {
            recipientsInfoBindingSource.DataSource = recInfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (recipientNameTextBox.Text=="")
            {
                if (MessageBox.Show(this, "Ничего не введено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) return;
            }
            else
            {
                if (recInfo.RecipientID > 0)
                {
                    recInfo.UpdateRecipient();
                }
                else
                {
                    recInfo.InsertNewRecipient();
                }
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}
