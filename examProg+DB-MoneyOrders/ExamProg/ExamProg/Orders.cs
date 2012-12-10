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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        OrdersList _ordersList = new OrdersList();
        OrderViewList _orderViewList = new OrderViewList();
        RecipientsList _recipientsList = new RecipientsList();
        SendersList _sendersList = new SendersList();
        ColourProperties _myColouring = new ColourProperties();
        FilterProperties _myFilter = new FilterProperties();


        private void LoadOrders()
        {
            _sendersList = SendersList.GetDefaultSendersList();
            sendersListBindingSource.DataSource = _sendersList;

            checkBox1.Checked = false;
            checkBox6.Checked = false;
            comboBox1.Items.Clear();
            comboBox6.Items.Clear();
            for (int i = 0; i < _sendersList.Count; i++)
            {
                comboBox1.Items.Add(_sendersList[i].SenderName);
                comboBox6.Items.Add(_sendersList[i].SenderName);
            }

            _recipientsList = RecipientsList.GetDefaultRecipientsList();
            recipientsListBindingSource.DataSource = _recipientsList;

            checkBox2.Checked = false;
            checkBox7.Checked = false;
            comboBox2.Items.Clear();
            comboBox7.Items.Clear();
            for (int i = 0; i < _recipientsList.Count; i++)
            {
                comboBox2.Items.Add(_recipientsList[i].RecipientName);
                comboBox7.Items.Add(_recipientsList[i].RecipientName);
            }

            _orderViewList = OrderViewList.GetDefaultOrderViewList();
            ordersInfoBindingSource.DataSource = _orderViewList;

            checkBox3.Checked = false;
            checkBox8.Checked = false;
            comboBox3.Items.Clear();
            comboBox8.Items.Clear();
            for (int i = 0; i < _orderViewList.Count; i++)
            {
                comboBox3.Items.Add(_orderViewList[i].OrderViewName);
                comboBox8.Items.Add(_orderViewList[i].OrderViewName);
            }

            _ordersList = OrdersList.GetDefaultOrdersList();
            ordersInfoBindingSource.DataSource = null;
            ordersInfoBindingSource.DataSource = _ordersList;
        }
        private void DeleteOrders()
        {
            if (ordersInfoDataGridView.SelectedRows.Count > 0)
            {
                int orderID = (int)ordersInfoDataGridView.SelectedRows[0].Cells[0].Value;
                foreach (OrdersInfo asd in _ordersList)
                {
                    if (asd.OrderID == orderID)
                    {
                        asd.DeleteOrders();
                    }
                }
            }
            LoadOrders();
        }
        private void AddNewOrder()
        {
            AddOrders NewOrder = new AddOrders();
            NewOrder.Text = "Добавить";
            NewOrder.ShowDialog();
            LoadOrders();
        }
        private void EditOrders()
        {
            if (ordersInfoDataGridView.SelectedRows.Count > 0)
            {
                int ordID = (int)ordersInfoDataGridView.SelectedRows[0].Cells[0].Value;
                foreach (OrdersInfo ordInf in _ordersList)
                {
                    if (ordInf.OrderID == ordID)
                    {
                        AddOrders newOrder = new AddOrders();
                        newOrder.Text = "Изменить";
                        newOrder._OrdersInfo = ordInf;
                        newOrder.ShowDialog();
                        break;
                    }
                }
                LoadOrders();
            }
            else
            {
                if (MessageBox.Show(this, "Ничего не выбрано!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK) return;
            }
        }

        private void UnColouringRows()
        {
            foreach (DataGridViewRow row in ordersInfoDataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
            }
        }
        private void ColoringRows()
        {
            lbColouringParameters.Text = "Количество параметров выделения: " + _myColouring.Count;
            ordersInfoDataGridView.ClearSelection();
            foreach (DataGridViewRow row in ordersInfoDataGridView.Rows)
            {
                for (int i = 0; i < _myColouring.Count; i++)
                {
                    if (row.Cells[_myColouring[i].Index].Value.ToString() == _myColouring[i].Value)
                    {
                        for (int j = 0; j < row.Cells.Count; j++)
                        {
                            row.Cells[j].Style.BackColor = _myColouring[i].Color;
                        }
                    }
                }
            }
        }
        private void ClearFilter()
        {
            _myFilter.Clear();
            RowsFilterApply();
            //ordersInfoBindingSource.DataSource = OrdersList.GetDefaultOrdersList();
            _ordersList = OrdersList.GetDefaultOrdersList();
            ordersInfoBindingSource.DataSource = null;
            ordersInfoBindingSource.DataSource = _ordersList;
        }
        private void RowsFilterApply()
        {
            lbFilterParameter.Text = "Количество параметров фильтрации: " + _myFilter.Count;
            ordersInfoDataGridView.ClearSelection();

            for (int j = 0; j < _myFilter.Count; j++)
            {
                switch (_myFilter[j].Index)
                {
                    case 1:
                        for (int i = _ordersList.Count-1; i >= 0; i--)
                        {
                            if (_ordersList[i].SenderName != _myFilter[j].Value)
                            {
                                _ordersList.RemoveAt(i);
                            }
                        }
                        break;
                  
                    case 2:
                        for (int i = _ordersList.Count - 1; i >= 0; i--)
                        {
                            if (_ordersList[i].RecipientName != _myFilter[j].Value)
                            {
                                _ordersList.RemoveAt(i);
                            }
                        }
                        break;
                   
                    case 3:
                        for (int i = _ordersList.Count - 1; i >= 0; i--)
                        {
                            if (_ordersList[i].OrderViewName != _myFilter[j].Value)
                            {
                                _ordersList.RemoveAt(i);
                            }
                        }
                        break;
                   
                    case 4:
                        for (int i = _ordersList.Count - 1; i >= 0; i--)
                        {
                            if (_ordersList[i].OrderSumma.ToString() != _myFilter[j].Value)
                            {
                                _ordersList.RemoveAt(i);
                            }
                        }
                        break;
                   
                    case 5:
                        for (int i = _ordersList.Count - 1; i >= 0; i--)
                        {
                            if (_ordersList[i].Date.ToString() != _myFilter[j].Value)
                            {
                                _ordersList.RemoveAt(i);
                            }
                        }
                        break;
                }
               
            }
            ordersInfoBindingSource.DataSource = null;
            ordersInfoBindingSource.DataSource = _ordersList;
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteOrders();
        }
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewOrder();
        }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditOrders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Width == 527)
            {
                this.Width = 840;
                button1.Text = "<<<<<";
            }
            else
            {
                this.Width = 527;
                button1.Text = ">>>>>";
            }
        }
        private void ordersInfoDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _ordersList = OrdersList.GetDefaultOrdersList();
            bool down = false;
            string s1 = "";
            string s2 = "";

            if (!down)
            {
                for (int i = 0; i < _ordersList.Count - 1; i++)
                {
                    for (int j = 0; j < _ordersList.Count - 1; j++)
                    {
                        switch (e.ColumnIndex)
                        {
                            case 1:
                                s1 = _ordersList[j].SenderName;
                                s2 = _ordersList[j + 1].SenderName;
                                break;
                           
                            case 2:
                                s1 = _ordersList[j].RecipientName;
                                s2 = _ordersList[j + 1].RecipientName;
                                break;
                           
                            case 3:
                                s1 = _ordersList[j].OrderViewName;
                                s2 = _ordersList[j + 1].OrderViewName;
                                break;
                           
                            case 4:
                                s1 = _ordersList[j].Date;
                                s2 = _ordersList[j + 1].Date;
                                break;
                          
                            case 5:
                                s1 = _ordersList[j].OrderSumma.ToString();
                                s2 = _ordersList[j + 1].OrderSumma.ToString();
                                break;
                        }

                        OrdersInfo _ordersInfo = new OrdersInfo();
                        _ordersInfo = _ordersList[j];

                        Char c1;
                        Char c2;

                        int M = s1.Length;

                        if (s2.Length < M)
                        {
                            M = s2.Length;
                        }

                        for (int a = 0; a < M; a++)
                        {
                            c1 = s1[a];
                            c2 = s2[a];

                            int d1 = (int)c1;
                            int d2 = (int)c2;

                            if (d2 < d1)
                            {

                                _ordersList.RemoveAt(j);
                                _ordersList.Insert(j + 1, _ordersInfo);
                                break;
                            }
                            if (d2 > d1)
                            {
                                break;
                            }
                            if (d1 == d2 & a == M - 1 & s1.Length > s2.Length)
                            {

                                _ordersList.RemoveAt(i);
                                _ordersList.Insert(j + 1, _ordersInfo);
                            }
                        }
                    }
                }
            }
            ordersInfoBindingSource.DataSource = _ordersList;
            ordersInfoDataGridView.Refresh();
            UnColouringRows();
            ColoringRows();
            RowsFilterApply();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            _myColouring.Clear();
            ColoringRows();
            UnColouringRows();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearFilter();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox1.SelectedItem = null;
                ClearFilter();
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBox2.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
                comboBox2.SelectedItem = null;
                ClearFilter();
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                comboBox3.Enabled = true;
            }
            else
            {
                comboBox3.Enabled = false;
                comboBox3.SelectedItem = null;
                ClearFilter();
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                ClearFilter();
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
              textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                ClearFilter();
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _myFilter.AddNewProperties(1, comboBox1.SelectedItem.ToString());
                RowsFilterApply();
            }
            catch
            {
                return;
            }
        }
        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _myFilter.AddNewProperties(2, comboBox2.SelectedItem.ToString());
                RowsFilterApply();
            }
            catch
            {
                return;
            }
        }
        private void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _myFilter.AddNewProperties(3, comboBox3.SelectedItem.ToString());
                RowsFilterApply();
            }
            catch
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog clr = new ColorDialog();
            clr.ShowDialog();
            pictureBox1.BackColor = clr.Color;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                comboBox6.Enabled = true;
            }
            else
            {
                comboBox6.Enabled = false;
                comboBox6.SelectedItem = null;
                ClearFilter();
            }
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                comboBox7.Enabled = true;
            }
            else
            {
                comboBox7.Enabled = false;
                comboBox7.SelectedItem = null;
                ClearFilter();
            }
        }
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                comboBox8.Enabled = true;
            }
            else
            {
                comboBox8.Enabled = false;
                comboBox8.SelectedItem = null;
                ClearFilter();
            }
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker2.Enabled = false;
                ClearFilter();
            }
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
                ClearFilter();
            }
        }

        private void comboBox6_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _myColouring.AddNewProperties(1, comboBox6.SelectedItem.ToString(), pictureBox1.BackColor);
                ColoringRows();
            }
            catch
            {
                return;
            }
        }
        private void comboBox7_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _myColouring.AddNewProperties(2, comboBox7.SelectedItem.ToString(), pictureBox1.BackColor);
                ColoringRows();
            }
            catch
            {
                return;
            }
        }
        private void comboBox8_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _myColouring.AddNewProperties(3, comboBox8.SelectedItem.ToString(), pictureBox1.BackColor);
                ColoringRows();
            }
            catch
            {
                return;
            }
        }

       
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                _myColouring.AddNewProperties(5, textBox2.Text.ToString(), pictureBox1.BackColor);
                ColoringRows();
            }
            catch
            {
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                _myFilter.AddNewProperties(4, textBox1.Text.ToString());
                RowsFilterApply();
            }
            catch
            {
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                _myFilter.AddNewProperties(5, dateTimePicker1.Value.ToShortDateString());
                RowsFilterApply();
            }
            catch
            {
                return;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                _myColouring.AddNewProperties(4, dateTimePicker2.Value.ToShortDateString(), pictureBox1.BackColor);
                ColoringRows();
            }
            catch
            {
                return;
            }
        }


    }
}
