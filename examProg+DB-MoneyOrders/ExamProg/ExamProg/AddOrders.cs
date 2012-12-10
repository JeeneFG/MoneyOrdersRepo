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
    public partial class AddOrders : Form
    {
        public AddOrders()
        {
            InitializeComponent();
        }

        public OrdersInfo _OrdersInfo = new OrdersInfo();
        OrderViewList _OrderViewList = new OrderViewList();
        RecipientsList _RecipientsList = new RecipientsList();
        SendersList _SendersList = new SendersList();

        private void AddOrders_Load(object sender, EventArgs e)
        {
            _OrderViewList = OrderViewList.GetDefaultOrderViewList();
            //orderViewsInfoBindingSource.DataSource = null;
            orderViewsInfoBindingSource.DataSource = _OrderViewList;

            _RecipientsList = RecipientsList.GetDefaultRecipientsList();
            //recipientsInfoBindingSource.DataSource = null;
            recipientsInfoBindingSource.DataSource = _RecipientsList;

            _SendersList = SendersList.GetDefaultSendersList();
            //sendersInfoBindingSource.DataSource = null;
            sendersInfoBindingSource.DataSource = _SendersList;


            if (_OrdersInfo != null)
            {
                ordersListBindingSource.DataSource = _OrdersInfo;
                orderViewNameComboBox.SelectedValue = _OrdersInfo.OrderViewName;
                recipientNameComboBox.SelectedValue = _OrdersInfo.RecipientName;
                senderNameComboBox.SelectedValue = _OrdersInfo.SenderName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (orderSummaTextBox.Text=="" | orderViewNameComboBox.SelectedValue==null | recipientNameComboBox.SelectedValue==null | senderNameComboBox.SelectedValue==null)
            {
                if (MessageBox.Show(this, "Ничего не введено!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) return;
            }
            else
            {
                _OrdersInfo.OrderSumma = System.Convert.ToInt32(orderSummaTextBox.Text);
               
                _OrdersInfo.OrderViewName = orderViewNameComboBox.SelectedValue.ToString();
                foreach (OrderViewsInfo ordViewInf in _OrderViewList)
                {
                    if (ordViewInf.OrderViewName == orderViewNameComboBox.SelectedValue.ToString())
                    {
                        _OrdersInfo.OrderViewID = ordViewInf.OrderViewID;
                    }
                }
               
                _OrdersInfo.RecipientName = recipientNameComboBox.SelectedValue.ToString();
                foreach (RecipientsInfo recInfo in _RecipientsList)
                {
                    if (recInfo.RecipientName == recipientNameComboBox.SelectedValue.ToString())
                    {
                        _OrdersInfo.RecipientID = recInfo.RecipientID;
                    }
                }
              
                _OrdersInfo.SenderName = senderNameComboBox.SelectedValue.ToString();
                foreach (SendersInfo senInfo in _SendersList)
                {
                    if (senInfo.SenderName == senderNameComboBox.SelectedValue.ToString())
                    {
                        _OrdersInfo.SenderID = senInfo.SenderID;
                    }
                }
                _OrdersInfo.Date = dateDateTimePicker.Value.ToShortDateString();
                if (_OrdersInfo.OrderID > 0)
                {

                    _OrdersInfo.UpdateOrders();
                }
                else
                {
                    _OrdersInfo.InsertNewOrders();
                }
                this.DialogResult = DialogResult.OK;
              }
        }
    }
}
