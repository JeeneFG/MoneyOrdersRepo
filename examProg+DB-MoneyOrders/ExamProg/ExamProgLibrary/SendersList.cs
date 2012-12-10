using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ExamProgLibrary
{
    public class SendersList:List<SendersInfo>
    {
        public static SendersList GetDefaultSendersList()
        {
            SendersList _sendersList = new SendersList();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "SelectSenders";

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                SendersInfo newSender = new SendersInfo();

                newSender.SenderID = int.Parse(dr["SenderID"].ToString());
                newSender.SenderName = dr["SenderName"].ToString();

                _sendersList.Add(newSender);
               
            }

            return _sendersList;
        }
    }
}
