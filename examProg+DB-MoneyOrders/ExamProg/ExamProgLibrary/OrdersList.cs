using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ExamProgLibrary
{
   public class OrdersList:List<OrdersInfo>
    {
       public static OrdersList GetDefaultOrdersList()
       {
           OrdersList _ordersList = new OrdersList();
           SqlConnection cn = new SqlConnection();
           cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
           cn.Open();

           SqlCommand cm = cn.CreateCommand();
           cm.CommandType = CommandType.StoredProcedure;
           cm.CommandText = "SelectOrdersList";

           SqlDataReader dr = cm.ExecuteReader();
           while (dr.Read())
           {
               OrdersInfo newOrder = new OrdersInfo();

               DateTime asdf = new DateTime();
               asdf = (DateTime)dr["Date"];

               newOrder.Date = asdf.ToShortDateString();

               newOrder.OrderID = int.Parse(dr["OrderID"].ToString());
               newOrder.SenderID = int.Parse(dr["SenderID"].ToString());
               newOrder.SenderName = dr["SenderName"].ToString();
               newOrder.RecipientID = int.Parse(dr["RecipientID"].ToString());
               newOrder.RecipientName = dr["RecipientName"].ToString();
               newOrder.OrderViewID = int.Parse(dr["OrderViewID"].ToString());
               newOrder.OrderViewName = dr["OrderViewName"].ToString();
               //newOrder.Date=(DateTime)dr["Date"];
               newOrder.OrderSumma = int.Parse(dr["OrderSumma"].ToString());

               _ordersList.Add(newOrder);

           }

           return _ordersList;
       }
    }
}
