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
    public partial class OrderViews : Form
    {
        
        public OrderViews()
        {
            InitializeComponent();
        }

       private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       OrderViewList _orderViewList = new OrderViewList();
       OrdersList _ordersList = new OrdersList();

       private void LoadOrdersViews()
       {
           _orderViewList = OrderViewList.GetDefaultOrderViewList();
           orderViewsInfoBindingSource.DataSource = null;
           orderViewsInfoBindingSource.DataSource = _orderViewList;
       }
       private void AddOrdersViews()
       {
           AddOrderViews newOrderView = new AddOrderViews();
           newOrderView.Text = "Добавить";
           newOrderView.ShowDialog();
           LoadOrdersViews();
       }
       private void EditOrdersViews()
       {
           if (orderViewsInfoDataGridView.SelectedRows.Count > 0)
           {
               int ordViewID = (int)orderViewsInfoDataGridView.SelectedRows[0].Cells[0].Value;
               foreach (OrderViewsInfo orderView in _orderViewList)
               {
                   if (orderView.OrderViewID == ordViewID)
                   {
                       AddOrderViews newOrdView = new AddOrderViews();
                       newOrdView.Text = "Изменить";
                       newOrdView.ordViewInf = orderView;
                       newOrdView.ShowDialog();
                       break;
                   }
               }
               LoadOrdersViews();
           }
           else
           {
               if (MessageBox.Show(this, "Ничего не выбрано!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK) return;
           }
       }
       private void DeleteOrdersViews()
       {
           if (orderViewsInfoDataGridView.SelectedRows.Count > 0)
           {
               int ordViewID = (int)orderViewsInfoDataGridView.SelectedRows[0].Cells[0].Value;
               foreach (OrderViewsInfo ordView in _orderViewList)
               {
                   if (ordView.OrderViewID == ordViewID)
                   {
                       try
                       {
                           ordView.DeleteOrderView();
                       }
                       catch
                       {
                           string str = "";
                           bool first = true;
                           for (int i = 0; i < _ordersList.Count; i++)
                           {
                               if (_ordersList[i].OrderViewName == ordView.OrderViewName)
                               {
                                   if (first)
                                   {
                                       str += " (" + _ordersList[i].OrderViewName;
                                       first = false;
                                   }
                                   else
                                   {
                                       str += ", " + _ordersList[i].OrderViewName;
                                   }
                               }
                           }
                           str += ")";
                           if (MessageBox.Show(this, "Данная запись не может быть удалена, т.к. она используется в главной таблице!" + str, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK) break;
                       }
                   }
               }
               LoadOrdersViews();
           }
           else
           {
               if (MessageBox.Show(this, "Ничего не выбрано!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.OK) return;
           }
       }

       private void OrderViews_Load(object sender, EventArgs e)
       {
           LoadOrdersViews();
       }
       private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
       {
           LoadOrdersViews();
       }
       private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
       {
           AddOrdersViews();
       }
       private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
       {
           EditOrdersViews();
       }
       private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
       {
           DeleteOrdersViews();
       }
    }
}
