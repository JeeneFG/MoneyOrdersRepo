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
    public partial class Senders : Form
    {
        public Senders()
        {
            InitializeComponent();
        }

        SendersList _sendersList = new SendersList();
        OrdersList _ordersList = new OrdersList();

        private void LoadSenders()
        {
            _sendersList = SendersList.GetDefaultSendersList();
            sendersInfoBindingSource.DataSource = null;
            sendersInfoBindingSource.DataSource = _sendersList;
        }
        private void AddSenders()
        {
            AddSenders newSender = new AddSenders();
            newSender.Text = "Добавить";
            newSender.ShowDialog();
            LoadSenders();
        }
        private void EditSenders()
        {
            if (sendersInfoDataGridView.SelectedRows.Count>0)
            {
                int sendID = (int)sendersInfoDataGridView.SelectedRows[0].Cells[0].Value;
                foreach (SendersInfo send in _sendersList)
                {
                    if (send.SenderID == sendID)
                    {
                        AddSenders newSender = new AddSenders();
                        newSender.Text = "Изменить";
                        newSender.senInfo = send;
                        newSender.ShowDialog();
                        break;
                    }
                }
                LoadSenders();
            }
            else
            {
                if (MessageBox.Show(this, "Ничего не выбрано!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK) return;
            }
        }
        private void DeleteSenders()
        {
            if (sendersInfoDataGridView.SelectedRows.Count>0)
            {
                int senID = (int)sendersInfoDataGridView.SelectedRows[0].Cells[0].Value;
                foreach (SendersInfo sen in _sendersList)
                {
                    if (sen.SenderID == senID)
                    {
                        try
                        {
                            sen.DeleteSender();
                        }
                        catch
                        {
                            string str = "";
                            bool first = true;
                            
                            for (int i = 0; i < _ordersList.Count; i++)
                            {
                                if (_ordersList[i].SenderName == sen.SenderName)
                                {
                                    if (first)
                                    {
                                        str += " (" + _ordersList[i].SenderName;
                                        first = false;
                                    }
                                    else
                                    {
                                        str += ", " + _ordersList[i].SenderName;
                                    }
                                }
                                
                            }
                            str += ")";
                            if (MessageBox.Show(this, "Данная запись не может быть удалена, т.к. она используется в главной таблице!" + str, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK) break;
                        }
                    }
                }
                LoadSenders();
            }
            else
            {
                if (MessageBox.Show(this, "Ничего не выбрано!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK) return;
            }           
        }

        private void Senders_Load(object sender, EventArgs e)
        {
            LoadSenders();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSenders();
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSenders();
        }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSenders();
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSenders();
        }

    }
}
