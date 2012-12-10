using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ExamProgLibrary
{
    public class OrderViewsInfo
    {
        private int _orderViewID = 0;
        private string _orderViewName = "";
    
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
            get
            {
                return _orderViewName;
            }
            set
            {
                _orderViewName = value;
            }
        }

        public void InsertNewOrderView()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();          
            cn.Open();
    
            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertOrderViews";

            cm.Parameters.Add(new SqlParameter("@OrderViewName", _orderViewName));
         
            cm.ExecuteNonQuery();
        }
        public void DeleteOrderView()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteOrderViews";

            cm.Parameters.Add(new SqlParameter("@OrderViewID", _orderViewID));

            cm.ExecuteNonQuery();
        }
        public void UpdateOrderView()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdateOrderViews";

            cm.Parameters.Add(new SqlParameter("@OrderViewID", _orderViewID));
            cm.Parameters.Add(new SqlParameter("@OrderViewName", _orderViewName));

            cm.ExecuteNonQuery();
        }
        public void GetOrderView(int orderViewID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "SelectOneOrderView";

            cm.Parameters.Add(new SqlParameter("@OrderViewID", orderViewID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                _orderViewName = dr["OrderViewName"].ToString();
            }
        }

    }
}
