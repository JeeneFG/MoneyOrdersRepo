using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ExamProgLibrary
{
    public class OrdersInfo
    {
        private int _orderID = 0;
        private int _senderID = 0;
        private string _senderName = "";
        private int _recipientID = 0;
        private string _recipientName = "";
        private int _orderViewID = 0;
        private string _orderViewName = "";
        //private DateTime _date = DateTime.Today;
        private string _date = "";
        private int _orderSumma = 0;

        public int OrderID
        {
            get
            {
                return _orderID;
            }
            set
            {
                _orderID = value;
            }
        }
        public int SenderID
        {
            get
            {
                return _senderID;
            }
            set
            {
                _senderID = value;
            }
        }
        public string SenderName
        {
            get { return _senderName; }
            set { _senderName = value; }
        }
        public int RecipientID
        {
            get
            {
                return _recipientID;
            }
            set
            {
                _recipientID = value;
            }
        }
        public string RecipientName
        {
            get { return _recipientName; }
            set { _recipientName = value; }
        }
        public int OrderViewID
        {
            get
            {
                return _orderViewID;
            }
            set
            {
                _orderViewID = value;
            }
        }
        public string OrderViewName
        {
            get { return _orderViewName; }
            set { _orderViewName = value; }
        }
        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        public int OrderSumma
        {
            get
            {
                return _orderSumma;
            }
            set
            {
                _orderSumma = value;
            }
        }

        public void InsertNewOrders()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertOrders";

            cm.Parameters.Add(new SqlParameter("@Date", _date));
            cm.Parameters.Add(new SqlParameter("@OrderSumma", _orderSumma));
            cm.Parameters.Add(new SqlParameter("@SenderID", _senderID));
            cm.Parameters.Add(new SqlParameter("@RecipientID", _recipientID));
            cm.Parameters.Add(new SqlParameter("@OrderViewID", _orderViewID));


            cm.ExecuteNonQuery();
        }
        public void DeleteOrders()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteOrders";

            cm.Parameters.Add(new SqlParameter("@OrderID", _orderID));

            cm.ExecuteNonQuery();
        }
        public void UpdateOrders()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdateOrders";

            cm.Parameters.Add(new SqlParameter("@OrderID", _orderID));
            cm.Parameters.Add(new SqlParameter("@SenderID", _senderID));
            cm.Parameters.Add(new SqlParameter("@RecipientID", _recipientID));
            cm.Parameters.Add(new SqlParameter("@OrderViewID", _orderViewID));
            cm.Parameters.Add(new SqlParameter("@Date", _date));
            cm.Parameters.Add(new SqlParameter("@OrderSumma", _orderSumma));

            cm.ExecuteNonQuery();
        }
        public void GetOrders(int ordersID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "SelectOneOrder";

            cm.Parameters.Add(new SqlParameter("@OrdersID", ordersID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                _orderViewName = dr["OrderViewName"].ToString();
                _orderViewID = (int)dr["OrderViewID"];
                _recipientName = dr["RecipientName"].ToString();
                _recipientID = (int)dr["RecipientID"];
                _senderName = dr["SenderName"].ToString();
                _senderID = (int)dr["SenderID"];
                _orderSumma = (int)dr["OrderSumma"];

                DateTime dt = new DateTime();
                dt = (DateTime)dr["Date"];
                _date = dt.ToShortDateString();
                //_date = (DateTime)dr["Date"];
            }

        }
    }
}
