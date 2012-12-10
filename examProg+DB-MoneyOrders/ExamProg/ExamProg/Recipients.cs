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
    public partial class Recipients : Form
    {
        public Recipients()
        {
            InitializeComponent();
        }

        RecipientsList _recipientsList = new RecipientsList();
        OrdersList _ordersList = new OrdersList();

        private void LoadRecipients()
        {
            _recipientsList = RecipientsList.GetDefaultRecipientsList();
            recipientsInfoBindingSource.DataSource = null;
            recipientsInfoBindingSource.DataSource = _recipientsList;
        }
        private void AddRecipients()
        {
            AddRecipients newRecipient = new AddRecipients();
            newRecipient.Text = "Добавить";
            newRecipient.ShowDialog();
            LoadRecipients();
        }
        private void EditRecipients()
        {
            if (recipientsInfoDataGridView.SelectedRows.Count>0)
            {
                int recipID = (int)recipientsInfoDataGridView.SelectedRows[0].Cells[0].Value;
                foreach (RecipientsInfo recipient in _recipientsList)
                {
                    if (recipient.RecipientID == recipID)
                    {
                        AddRecipients newRecip = new AddRecipients();
                        newRecip.Text = "Изменить";
                        newRecip.recInfo = recipient;
                        newRecip.ShowDialog();
                        break;
                    }
                }
                LoadRecipients();
            }
            else
            {
                if (MessageBox.Show(this, "Ничего не выбрано!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK) return;   
            }
        }
        private void DeleteRecipients()
        {
            if (recipientsInfoDataGridView.SelectedRows.Count > 0)
            {
                int recID = (int)recipientsInfoDataGridView.SelectedRows[0].Cells[0].Value;
                foreach (RecipientsInfo rec in _recipientsList)
                {
                    if (rec.RecipientID == recID)
                    {
                        try
                        {
                            rec.DeleteRecipient();
                        }
                        catch
                        {
                            string str = "";
                            bool first = true;
                            for (int i = 0; i < _ordersList.Count; i++)
                            {
                                if (_ordersList[i].RecipientName == rec.RecipientName)
                                {
                                    if (first)
                                    {
                                        str += " (" + _ordersList[i].RecipientName;
                                        first = false;
                                    }
                                    else
                                    {
                                        str += ", " + _ordersList[i].RecipientName;
                                    }
                                }
                            }
                            str += ")";
                            if (MessageBox.Show(this, "Данная запись не может быть удалена, т.к. она используется в главной таблице!" + str, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK) break;
                        }
                    }
                }
                LoadRecipients();
            }
            else
            {
                if (MessageBox.Show(this, "Ничего не выбрано!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK) return;
            }      
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadRecipients();
        }
        private void Recipients_Load(object sender, EventArgs e)
        {
            LoadRecipients();
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRecipients();
        }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditRecipients();
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRecipients();
        }
    }
}
