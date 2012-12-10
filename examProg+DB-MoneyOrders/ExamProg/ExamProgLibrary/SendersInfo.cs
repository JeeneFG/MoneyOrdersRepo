using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ExamProgLibrary
{
    public class SendersInfo
    {
        private int _senderID = 0;
        private string _senderName = "";

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
            get
            {
                return _senderName;
            }
            set
            {
                _senderName = value;
            }
        }
      
        public void InsertNewSender()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertSenders";

            cm.Parameters.Add(new SqlParameter("@SenderName", _senderName));

            cm.ExecuteNonQuery();
        }
        public void DeleteSender()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteSenders";

            cm.Parameters.Add(new SqlParameter("@SenderID", _senderID));

            cm.ExecuteNonQuery();
        }
        public void UpdateSender()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdateSenders";

            cm.Parameters.Add(new SqlParameter("@SenderID", _senderID));
            cm.Parameters.Add(new SqlParameter("@SenderName", _senderName));

            cm.ExecuteNonQuery();
        }
        public void GetSender(int senderID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "SelectOneSender";

            cm.Parameters.Add(new SqlParameter("@SenderID", senderID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                _senderName = dr["SenderName"].ToString();
            }
        }
    }
}
