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
    public partial class AddSenders : Form
    {
        public AddSenders()
        {
            InitializeComponent();
        }

        public SendersInfo senInfo = new SendersInfo();

        private void AddSenders_Load(object sender, EventArgs e)
        {
            sendersInfoBindingSource.DataSource = senInfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (senderNameTextBox.Text == "")
            {
                if (MessageBox.Show(this, "Ничего не введено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error)==DialogResult.OK) return;
            }
            else
            {
                if (senInfo.SenderID>0)
                {
                    senInfo.UpdateSender();
                }
                else
                {
                    senInfo.InsertNewSender();      
                }
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}
