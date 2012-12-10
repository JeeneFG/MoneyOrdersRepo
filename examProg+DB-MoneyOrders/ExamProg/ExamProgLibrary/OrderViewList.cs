using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ExamProgLibrary
{
    public class OrderViewList : List<OrderViewsInfo>
    {
        public static OrderViewList GetDefaultOrderViewList()
        {
            OrderViewList _orderViewList = new OrderViewList();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "SelectOrderViews";

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                OrderViewsInfo newOrderView = new OrderViewsInfo();
                newOrderView.OrderViewID = int.Parse(dr["OrderViewID"].ToString());
                newOrderView.OrderViewName = dr["OrderViewName"].ToString();

                _orderViewList.Add(newOrderView);
            }

            return _orderViewList;
        }
    }
}
